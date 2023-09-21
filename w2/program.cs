using System;
using System.Collections.Generic;
using System.IO;

namespace PersonalJournal
{
    class Program
    {
        private static List<JournalEntry> journalEntries = new List<JournalEntry>();

        static void Main(string[] args)
        {
            // Display the menu
            Console.WriteLine("Personal Journal");
            Console.WriteLine("-----------------");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            // Get the user's choice
            int choice = Convert.ToInt32(Console.ReadLine());

            // Switch on the user's choice
            switch (choice)
            {
                case 1:
                    WriteNewEntry();
                    break;
                case 2:
                    DisplayJournal();
                    break;
                case 3:
                    SaveJournalToFile();
                    break;
                case 4:
                    LoadJournalFromFile();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        private static void WriteNewEntry()
        {
            // Prompt the user for a prompt
            Console.WriteLine("Enter a prompt: ");
            string prompt = Console.ReadLine();

            // Get the user's response to the prompt
            Console.WriteLine("Enter your response: ");
            string response = Console.ReadLine();

            // Create a new journal entry and add it to the list of journal entries
            journalEntries.Add(new JournalEntry(prompt, response, DateTime.Now));
        }

        private static void DisplayJournal()
        {
            // Iterate through the list of journal entries and display them to the screen
            foreach (JournalEntry entry in journalEntries)
            {
                Console.WriteLine($"**Prompt:** {entry.Prompt}");
                Console.WriteLine($"**Response:** {entry.Response}");
                Console.WriteLine($"**Date:** {entry.Date}");
            }
        }

        private static void SaveJournalToFile()
        {
            // Prompt the user for a filename
            Console.WriteLine("Enter a filename to save the journal to: ");
            string filename = Console.ReadLine();

            // Open a file stream to the specified filename
            using (StreamWriter writer = new StreamWriter(filename))
            {
                // Write the journal entries to the file
                foreach (JournalEntry entry in journalEntries)
                {
                    writer.WriteLine($"{entry.Prompt},{entry.Response},{entry.Date}");
                }
            }
        }

        private static void LoadJournalFromFile()
        {
            // Prompt the user for a filename
            Console.WriteLine("Enter a filename to load the journal from: ");
            string filename = Console.ReadLine();

            // Open a file stream to the specified filename
            using (StreamReader reader = new StreamReader(filename))
            {
                // Read the journal entries from the file
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(',');

                    // Create a new journal entry from the line
                    JournalEntry entry = new JournalEntry(parts[0], parts[1], DateTime.Parse(parts[2]));

                    // Add the journal entry to the list of journal entries
                    journalEntries.Add(entry);
                }
            }
        }
    }

    class JournalEntry
    {
        public JournalEntry(string prompt, string response, DateTime date)
        {
            Prompt = prompt;
            Response = response;
            Date = date;
        }

        public string Prompt { get; set; }
        public string Response { get; set; }
        public DateTime Date { get; set; }
    }
}
