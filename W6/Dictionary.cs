using System;

public class Dictionary
{
    // Attributes
    private List<string> _dictionary = new List<string> ();
   
    // Constructors
    public List<string> GetList(string fileName)
    {
        LoadWords(fileName);
        return _dictionary;
    }
    public void AddWord(string word)
    {
        _dictionary.Add(word);
    }
    // Methods

    public void LoadWords(string fileName)
    {
        // Get file with words
        // string fileName = "words2.txt";
        // Read file into dictionary
        string[] readText = File.ReadAllLines(fileName);

        // loop though text file for words
        foreach (string line in readText)
        {
            string entries = line;
            AddWord(entries);
        }
        // test to see if words loaded into word dictionary list
        // _dictionary.ForEach(Console.WriteLine);

    }
}