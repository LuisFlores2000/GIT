using System;

public class GameMenu : Menu
{
    // Attributes 
    private new string _menu = $@"
                Game Options
===========================================
Your Game Options are:
1. Random Words
2. Pick your word topic
3. Back to Main Menu
===========================================
Which game would you like to play?  ";

    // Constructors

    // Methods
    public override void DisplayMenu()
    {
        Console.Write(_menu);
    }
    public override void MenuChoice()
    {
        // Call ListMenu
        Menu listMenu = new ListMenu();

        while (_action != 3)
        // switch case for goals menu
        {
            _action = UserChoice();
            switch (_action)
            {
                case 1:
                    // Random Words
                    // start game
                    _wordFileName = "words2.txt";
                    Hangman game = new Hangman();
                    game.StartGame(_wordFileName);
                    break;
                case 2:
                    // Pick your word topic
                    Console.Clear();  // This will clear the console
                    listMenu.MenuChoice();
                    break;
                case 3:
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