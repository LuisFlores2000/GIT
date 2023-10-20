using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Call MainMenu
        Menu choice = new MainMenu();
        
        choice.MenuChoice();

    }
}