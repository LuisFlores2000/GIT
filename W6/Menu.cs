using System;

public abstract class Menu
{
    // Attributes
    public string _menu { get; set; }
    protected string _userInput { get; set; }
    protected int _userChoice;
    protected int _action;
    protected string _wordFileName { get; set; }


    // Constructors


    // Methods
    // public abstract int UserChoice();
    public abstract void DisplayMenu();
    public int UserChoice()
    // Method to display choices to user
    {
        DisplayMenu();

        _userInput = Console.ReadLine();
        _userChoice = 0;
        // This block catches any non integer values that are entered
        try
        {
            _userChoice = int.Parse(_userInput);
        }
        catch (FormatException)
        {
            _userChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return _userChoice;
    }
    public abstract void MenuChoice();

}