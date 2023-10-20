using System;

public class ScoreScrabble : ScoringRules
{
    // Attributes
    Dictionary<string, int> scrabble = new Dictionary<string, int>()
        {
            {"e", 1},
            {"a", 1},
            {"i", 1},
            {"o", 1},
            {"n", 1},
            {"r", 1},
            {"t", 1},
            {"l", 1},
            {"s", 1},
            {"u", 1},
            {"d", 2},
            {"g", 2},
            {"b", 3},
            {"c", 3},
            {"m", 3},
            {"p", 3},
            {"f", 4},
            {"h", 4},
            {"v", 4},
            {"w", 4},
            {"y", 4},
            {"k", 5},
            {"j", 8},
            {"x", 8},
            {"q", 10},
            {"z", 10}
        };
    private int score;

    // Constructors


    // Methods
    public override int CalculateScore(int numGuesses, List<string> letters, string word)
    // Scrabble Score for the word
    {
        score = 0;
        foreach (string c in letters)
        {
            string letter = c.ToString().ToLower();
            if (scrabble.ContainsKey(letter))
            {
                score += scrabble[letter];
            }
        }
        // Console.WriteLine("The score for the word '{0}' is {1}.", letters, score);
        return score;
    }
    public override void ShowScore()
    {
        Console.WriteLine($"Your scrabble word score: {score} ");
    }





}