using System;

public class GallowsRenderer
{
    // Attributes
    // Constructors
    // Methods
    public void ShowGallows(int wrongGuessCount)
    {
        if (wrongGuessCount == 1)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine("    |");
            Console.WriteLine("    |");
            Console.WriteLine("    |");
            Console.WriteLine("   ===");
        }
        else if (wrongGuessCount == 2)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine("O   |");
            Console.WriteLine("    |");
            Console.WriteLine("    |");
            Console.WriteLine("   ===");
        }
        else if (wrongGuessCount == 3)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine("O   |");
            Console.WriteLine("|   |");
            Console.WriteLine("    |");
            Console.WriteLine("   ===");
        }
        else if (wrongGuessCount == 4)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine(" O  |");
            Console.WriteLine("/|  |");
            Console.WriteLine("    |");
            Console.WriteLine("   ===");
        }
        else if (wrongGuessCount == 5)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine(" O  |");
            Console.WriteLine("/|\\ |");
            Console.WriteLine("    |");
            Console.WriteLine("   ===");
        }
        else if (wrongGuessCount == 6)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine(" O  |");
            Console.WriteLine("/|\\ |");
            Console.WriteLine("/   |");
            Console.WriteLine("   ===");
        }
        else if (wrongGuessCount == 7)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine(" O   |");
            Console.WriteLine("/|\\  |");
            Console.WriteLine("/ \\  |");
            Console.WriteLine("    ===");
        }
    }
}