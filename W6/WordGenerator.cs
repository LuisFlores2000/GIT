using System;

public class WordGenerator
{
    // Attributes
    private string _randomWord;
    private int _index;

    // Constructors

    // Methods
    public string GetRandomWord(string fileName)
    {
        Random random = new Random();
        Dictionary dictionary = new Dictionary();

        List<string> calledList = dictionary.GetList(fileName);

        _index = random.Next(calledList.Count);
        _randomWord = calledList[_index];

        return _randomWord;
    }

    public int GetRandomWordCount()
    {
        return _randomWord.Length;
    }

}