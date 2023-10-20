using System;
using System.Collections.Generic;
using System.Text;

public class PrintLines
{
    // Attributes
    // Constructors
    // Methods
    public void GetLines(String randomWord)
        {
            Console.Write("\r");
            foreach (char c in randomWord)
            {
                Console.OutputEncoding = Encoding.Unicode;
                // Console.Write("\u0305 ");  //Unicode Character “◌̅” (U+0305) - Combining Overline
                Console.Write("\u005f ");  // Unicode Character “_” (U+005F) - Low Line
                // Console.Write("\u10191 ");
            }
        }

}