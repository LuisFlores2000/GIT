using System;

namespace ScriptureMemorization
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create a scripture
            Scripture scripture = new Scripture("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

            // Play the memorization game
            PlayGame(scripture);
        }

        private static void ShowScripture(Scripture scripture)
        {
            Console.WriteLine("The scripture is:");
            Console.WriteLine(scripture.GetText());
        }

        private static void HideRandomWords(Scripture scripture)
        {
            // Get a list of all the words in the scripture
            List<Word> words = scripture.GetWords();

            // Hide some words randomly
            int numWordsToHide = words.Count / 2;
            for (int i = 0; i < numWordsToHide; i++)
            {
                int index = rnd.Next(words.Count);
                words[index].IsHidden = true;
            }
        }

        private static void PlayGame(Scripture scripture)
        {
            // Show the full scripture
            ShowScripture(scripture);

            // Hide some words randomly
            HideRandomWords(scripture);

            // Play the game until all the words are hidden
            while (scripture.GetWords().Any(word => word.IsHidden))
            {
                // Ask the user to type the scripture text
                string text = Console.ReadLine();

                // Check the user's answer
                bool correct = true;
                for (int i = 0; i < scripture.GetWords().Count; i++)
                {
                    if (scripture.GetWords()[i].IsHidden && text.IndexOf(scripture.GetWords()[i].GetText()) == -1)
                    {
                        correct = false;
                        break;
                    }
                }

                // Show the result to the user
                if (correct)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }

                // Hide some words randomly
                HideRandomWords(scripture);
            }

            // Show a congratulations message
            Console.WriteLine("Congratulations! You have memorized the scripture.");
        }
    }
}
