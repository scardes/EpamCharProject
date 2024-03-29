﻿using System;

#nullable enable

/// <summary>
/// Console program which accepts a sequence of characters (string) as an argument and 
/// prints the maximum number of different sequential characters into the console
/// Add two functions FindUniqueLetter and FindUniqueDigit 
/// And Unit Test for three functions (FindUniqueDigit with DataRow)
/// </summary>
namespace EpamCharProject
{
    public class Program
    {
        private static void Main()
        {
            bool endApp = false;

            // Repeat program, until input key "n" to exit.
            while (!endApp) 
            {
                Console.WriteLine("Enter a string to search for a sequence of unique characters: ");

                // Ask the user to type the string? (nullable sequence of characters)
                string? inputLine = Console.ReadLine();

                // Invoke metod FindUnique with inputStr
                Unique unicLine = new Unique();
                
                string unicStr = unicLine.FindUnique(inputLine);
                string unicStrLetter = unicLine.FindUniqueLetter(inputLine);
                string unicStrDigit = unicLine.FindUniqueDigit(inputLine);


                Console.WriteLine("\nMAX unique symbols is: {0}", unicStr); 

                Console.WriteLine("\nMAX unique  LETTER is: {0}", unicStrLetter);

                Console.WriteLine("\nMAX unique   DIGIT is: {0}", unicStrDigit);
                Console.WriteLine("------------------------\n");


                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any key and Enter to continue: ");

                if (Console.ReadLine() == "n")
                {
                    endApp = true;
                }

                Console.WriteLine("\n"); // Friendly linespacing
            }
        }

        
    }
}