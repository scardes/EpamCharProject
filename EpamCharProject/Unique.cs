using System;
using System.Collections.Generic;
using System.Text;

namespace EpamCharProject
{
    public class Unique
    {


        /// <summary>
        /// First metod find max unique line of symbols in string (without changes)
        /// </summary>
        public string FindUnique(string inputLine)
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

        /// <summary>
        /// Second metod find max unique LETTER line of symbols in string (just copy of first metod for now)
        /// TO DO change to char[] and use metod char.IsLetter
        /// </summary>
        public string FindUniqueLetter(string inputLine)
        {
            string uniqueStr = "";
            string maxUniqueStr = "";
            string maxUniqueStrTemp;

            char[] symbols = inputLine.ToCharArray();

            // If "symbols" has only one symbol
            if (symbols.Length == 1)
            {
                maxUniqueStr = inputLine;
            }

            for (int i = 0; i < symbols.Length; i++)
            {
                if (true)
                {

                }
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
