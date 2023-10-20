using System;

public class ScoreBoard
{
    // Attributes
    private ScoringRules scoringRules;

    // Constructors
    public ScoreBoard(ScoringRules scoringRules)
    {
        this.scoringRules = scoringRules;
    }


    // Methods
    public void DisplayScore(int numGuesses, List<string> letters, string word)
    {
        int score = scoringRules.CalculateScore(numGuesses, letters, word);
        // Console.WriteLine($"Your Score: {score}");
        scoringRules.ShowScore();

    }


}