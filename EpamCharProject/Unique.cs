using System;

namespace EpamCharProject
{
    /// <summary>
    /// Class for trainin Unit Tests. Find Unique Chars/Letters/Digit
    /// </summary>
    public class Unique
    {
        /// <summary>
        /// First metod find max unique line of symbols in string (without changes)
        /// </summary>
        public string FindUnique(string inputLine)
        {
            string uniqueStr = "";
            string maxUniqueStr = "";
            string maxUniqueStrTemp = "";

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

        /// <summary>
        /// Second metod find max unique LETTER line of symbols in string;
        /// (It`s copy for purpose of learning Unit Tests)
        /// String change to char[] and use metod char.IsLetter
        /// </summary>
        public string FindUniqueLetter(string inputLine)
        {
            string uniqueStr = "";
            string maxUniqueStr = "";
            string maxUniqueStrTemp = "";

            char[] symbols = inputLine.ToCharArray();

            // If "symbols" has only one Letter
            if ((symbols.Length == 1) && char.IsLetter(symbols[0]))
            {
                maxUniqueStr = inputLine;
            }
           
            for (int i = 0; i < (symbols.Length - 1); i++)
            {
                // NOT is equal symbols, collect if they are Letter 
                if (inputLine[i] != inputLine[i + 1])
                {
                    if (char.IsLetter(symbols[i]))
                    {
                        uniqueStr += inputLine[i];
                    }

                    if (char.IsLetter(symbols[i + 1]))
                    {
                        maxUniqueStrTemp = uniqueStr + inputLine[i + 1];
                    }

                    // Both char is NOT Letter: reset collectors
                    if (!char.IsLetter(symbols[i]) && !char.IsLetter(symbols[i + 1]))
                    {
                        uniqueStr = "";
                        maxUniqueStrTemp = "";
                    } 
                }

                // Equal symbols: reset collectors
                else
                {
                    uniqueStr = "";
                    maxUniqueStrTemp = "";
                }

                // If "inputLine" has only same letters (like "aaaaa")
                if (maxUniqueStrTemp.Length == 0 && char.IsLetter(symbols[0]))
                {
                    maxUniqueStrTemp += symbols[0];
                }

                // Safe unique max string 
                if (maxUniqueStrTemp.Length > maxUniqueStr.Length)
                {
                    maxUniqueStr = maxUniqueStrTemp;
                }
            }
            
            return maxUniqueStr;
        }

        /// <summary>
        /// Third metod find max unique DIGIT line of symbols in string;
        /// (It`s copy for purpose of learning Unit Tests)
        /// String change to char[] and use metod char.IsDigit
        /// </summary>
        public string FindUniqueDigit(string inputLine)
        {
            string uniqueStr = "";
            string maxUniqueStr = "";
            string maxUniqueStrTemp = "";

            char[] symbols = inputLine.ToCharArray();

            // If "symbols" has only one digit
            if ((symbols.Length == 1) && char.IsDigit(symbols[0]))
            {
                maxUniqueStr = inputLine;
            }

            for (int i = 0; i < (symbols.Length - 1); i++)
            {
                // NOT is equal symbols, collect if they are digit 
                if (inputLine[i] != inputLine[i + 1])
                {
                    if (char.IsDigit(symbols[i]))
                    {
                        uniqueStr += inputLine[i];
                    }

                    if (char.IsDigit(symbols[i + 1]))
                    {
                        maxUniqueStrTemp = uniqueStr + inputLine[i + 1];
                    }

                    // Both char is NOT digits: reset collectors
                    if (!char.IsDigit(symbols[i]) && !char.IsDigit(symbols[i + 1]))
                    {
                        uniqueStr = "";
                        maxUniqueStrTemp = "";
                    }
                }

                // Equal symbols: reset collectors
                else
                {
                    uniqueStr = "";
                    maxUniqueStrTemp = "";
                }

                // If "inputLine" has only same gidits (like "55555")
                if (maxUniqueStrTemp.Length == 0 && char.IsDigit(symbols[0]))
                {
                    maxUniqueStrTemp += symbols[0];
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
