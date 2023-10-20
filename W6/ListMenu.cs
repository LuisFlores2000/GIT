using System;

public class ListMenu : Menu
{
    // Attributes 
    private new string _menu = $@"
                List Options
===========================================
Your list Options are:
1. Colors
2. Sports
3. Seasons
4. Back to Game Menu
===========================================
Which list would you like to use?  ";

    // Constructors


    // Methods
    public override void DisplayMenu()
    {
        Console.Write(_menu);
    }
    public override void MenuChoice()
    {
        while (_action != 4)
        // switch case for list menu
        {
            Hangman game = new Hangman();
            _action = UserChoice();
            switch (_action)
            {
                case 1:
                    // Console.WriteLine("Success Choice 1!");
                    _wordFileName = "colors.txt";
                    game.StartGame(_wordFileName);
                    break;
                case 2:
                    _wordFileName = "sports.txt";
                    game.StartGame(_wordFileName);
                    // Console.WriteLine("Success Choice 2!");
                    break;
                case 3:
                    _wordFileName = "seasons.txt";
                    game.StartGame(_wordFileName);
                    // Console.WriteLine("Success Choice 3!");
                    break;
                case 4:
                    // Back to Main Menu
                    Console.Clear();  // This will clear the console
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }
}