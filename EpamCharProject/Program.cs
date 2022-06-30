using System;

#nullable enable

/// <summary>
/// Console program which accepts a sequence of characters (string) as an argument and 
/// prints the maximum number of different sequential characters into the console
/// </summary>
namespace EpamCharProject
{
    class Program
    {
        static void Main()
        {
            bool endApp = false;

            // Repeat program, until input key "n" to exit.
            while (!endApp) 
            {
                Console.WriteLine("Enter a string to search for a sequence of unique characters: ");

                // Ask the user to type the string? (nullable sequence of characters)
                string? inputLine = Console.ReadLine(); 

                // Invoke metod FindUnique with inputStr
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

            /// <summary>
            /// Metod find max unique line of symbols in string
            /// </summary>
            static string FindUnique(string inputLine)
            {
                string uniqueStr = "";
                string maxUniqueStr = "";
                string maxUniqueStrTemp;

                // If "inputLine" has only one symbol
                if (inputLine.Length == 1)
                {
                    maxUniqueStr = inputLine;
                }

                // If "inputLine" has more than 2 symbols. 
                for (int i = 0; i < (inputLine.Length - 1); i++) 
                {
                    // NOT is equal symbols, collect both symbols
                    if (inputLine[i] != inputLine[i + 1]) 
                    {
                        uniqueStr += inputLine[i];
                        maxUniqueStrTemp = uniqueStr + inputLine[i + 1]; 
                    }

                    // Equal symbols: reset collectors
                    else 
                    {
                        uniqueStr = "";
                        maxUniqueStrTemp = "";
                    }

                    // If "inputLine" has only same symbols (like "11111")
                    if (maxUniqueStrTemp.Length == 0)
                    {
                        maxUniqueStrTemp += inputLine[0]; 
                    }

                    // Safe unique max string 
                    if (maxUniqueStrTemp.Length > maxUniqueStr.Length)
                    {
                        maxUniqueStr = maxUniqueStrTemp; 
                    }

                }
                
                return maxUniqueStr;
            }
        }
    }
}