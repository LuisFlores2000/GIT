using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;

public class Hangman
{
    // Attributes
    private string _letterGuessed;
    private Player player;
    private GallowsRenderer gallowsRenderer;
    private WordGenerator randomWord;
    private PrintLines printLines;
    private ScoreBoard simpleScore = new ScoreBoard(new ScoreSimple());
    private ScoreBoard complexScore = new ScoreBoard(new ScoreComplex());
    private ScoreBoard scrabbleScore = new ScoreBoard(new ScoreScrabble());


    // Constructors
    public Hangman()
    {
        player = new Player();
        gallowsRenderer = new GallowsRenderer();
        randomWord = new WordGenerator();
        printLines = new PrintLines();
    }
    // Methods

    public void StartGame(string fileName)
    {
        Console.Clear();  // This will clear the console
        SelectRandomWord(fileName);
        // DisplayRandomWord();
        player.ShowRandomWord();
        do
        {
            Console.Clear();  // This will clear the console
            // DisplayRandomWord();
            ShowTitle();
            ShowGallows();
            ShowLettersGuessesRight();
            ShowLettersGuessedWrong();
            ShowNumberOfGuesses();
            // ShowPlayerScore();
            PromptPlayerForLetter();
            CheckPlayerGuess();
        } while (!player.GameOver());

        GameOver();
        PlayAgain();

    }
    private void SelectRandomWord(string fileName)
    {
        player.randomWord = randomWord.GetRandomWord(fileName);
    }
    private void DisplayRandomWord()
    {
        Console.WriteLine("\n{0}", player.randomWord);
    }

    private void PromptPlayerForLetter()
    {
        do
        {
            Console.Write("Guess a letter >>  ");
            string g = Console.ReadLine();
            _letterGuessed = g.Substring(0, 1);
        } while (player.CheckIfGuessed(player, _letterGuessed));

        player.lettersGuessed.Add(_letterGuessed);
    }
    private void CheckPlayerGuess()
    {
        player.CheckLatestGuess(_letterGuessed);
        player.ShowRandomWord();
    }

    private void PlayAgain()
    {
        Console.WriteLine($"\nWould you like to play again?, press enter to continue.");

        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Enter)
        {
            Console.Clear();  // This will clear the console
        }
    }

    private void ShowNumberOfGuesses()
    {
        Console.WriteLine($"\nGuesses Left = {player.wrongGuessCount}/7\n");
    }

    private void ShowGallows()
    {
        gallowsRenderer.ShowGallows(player.wrongGuessCount);
    }

    private void ShowLettersGuessesRight()
    {
        Console.WriteLine($"\n{player.showRandomWord}\n");
    }

    private void ShowLettersGuessedWrong()
    {
        Console.WriteLine($"\n{player.wrongGuesses}\n");
    }

    private void ShowTitle()
    {
        Console.WriteLine($"*** Lets Play Hangman ***\n");
    }

    private void ShowPlayerScore()
    {
        if (!player.PlayerLost())
        {
            simpleScore.DisplayScore(player.correctGuessCount, player.rightGuessList, player.randomWord);
            scrabbleScore.DisplayScore(player.correctGuessCount, player.rightGuessList, player.randomWord);
            complexScore.DisplayScore(player.correctGuessCount, player.rightGuessList, player.randomWord);
        }
        else
        {
            simpleScore.DisplayScore(0, player.emptyList, player.randomWord);
            scrabbleScore.DisplayScore(0, player.emptyList, player.randomWord);
            complexScore.DisplayScore(0, player.emptyList, player.randomWord);
        }
    }

    private void GameOver()
    {
        Console.Clear();  // This will clear the console
        if (player.GameOver() && player.PlayerWon())
        {
            Console.WriteLine("*** Congratulations You Won! ***");
        }
        else
        {
            Console.WriteLine("*** Sorry, you lost! ***");
        }
        ShowGallows();
        ShowNumberOfGuesses();
        Console.WriteLine($"\nThe word was - {player.randomWord}\n");
        ShowPlayerScore();
    }


}