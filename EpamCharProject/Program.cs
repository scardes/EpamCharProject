using System;

namespace EpamCharProject
{
    /// <summary>
    /// Console program which accepts a sequence of characters (string) as an argument and 
    /// prints the maximum number of different sequential characters into the console
    /// </summary>
    class Program
    {
        static void Main()
        {
            bool endApp = false;

            // Repeat program, until input key "n" to exit.
            while (!endApp) 
            {
                Console.WriteLine("Enter a string to search for a sequence of unique characters");

                // Ask the user to type the string (sequence of characters)
                string? inputLine = Console.ReadLine(); // "string?" - for nullable string

                // Invoke 
                Console.WriteLine("\nMAX unique symbols is: {0}", FindUnique(inputLine)); 
                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any key and Enter to continue: ");

                if (Console.ReadLine() == "n")
                {
                    endApp = true;
                } 
                    
                Console.WriteLine("\n"); // Friendly linespacing
            }
            return;

            
            string FindUnique(string inputLine)
            {
                string uniqueStr = "";
                string uniqueStrMax = "";
                string uniqueStrMaxTemp;

                // If "inputLine" has only one symbol
                if (inputLine.Length == 1)
                {
                    uniqueStrMax = inputLine;
                }

                for (int i = 0; i < (inputLine.Length - 1); i++) // (inputLine.Length - 1) - To avoid the Error: 'Index was outside the bounds of the array.'
                {
                    // If symbols NOT is equal, safe both symbols
                    if (inputLine[i] != inputLine[i + 1]) 
                    {
                        uniqueStr += inputLine[i]; // Safe current symbol
                        uniqueStrMaxTemp = uniqueStr + inputLine[i + 1]; // Safe next symbol
                    }

                    // If symbols is equal: reset collectors
                    else 
                    {
                        uniqueStr = "";
                        uniqueStrMaxTemp = "";
                    }

                    // If "inputLine" has only same symbols (like "11111")
                    if (uniqueStrMaxTemp.Length == 0)
                    {
                        uniqueStrMaxTemp += inputLine[0]; 
                    }

                    // Safe unique max string 
                    if (uniqueStrMaxTemp.Length > uniqueStrMax.Length)
                    {
                        uniqueStrMax = uniqueStrMaxTemp; 
                    }

                }

                return uniqueStrMax;
            }
        }
    }
}