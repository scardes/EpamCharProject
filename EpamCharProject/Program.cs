using System;

namespace EpamCharProject
{
    //Написать программу, которая принимает из командной строки последовательность символов (строку) в качестве аргумента 
    // и выводит в консоль максимальное количество неодинаковых последовательных символов в строке
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input string for search");
            string? str = Console.ReadLine();
            //char charFirst = str[0];
            //char charSecond = str[0];
            int countMax = 0;
            int countTemp = 0;

            //foreach (char se in str)
            //{
            //    Console.WriteLine(se);
            //}

            for (int i = 0; i < (str.Length-1); i++)
            {

                if (str[i] == str[i+1])
                {
                    Console.WriteLine("Похожий символ - {0}, сравниваем с {1}", str[i], str[i+1]);                    
                }
                else
                {
                    Console.WriteLine("Разный 1 символ - {0}, сравниваем с {1}", str[i], str[i + 1]);
                    countMax++;
                }
            }
            Console.WriteLine("В строке {0}, кол-во max уник послед символов - {1}",str, countMax);
        }
    }
}
