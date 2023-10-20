using System;

public abstract class ScoringRules
{
    // Attributes


    // Constructors


    // Methods
    public abstract int CalculateScore(int numGuesses, List<string> letters, string word);

    public abstract void ShowScore();



}