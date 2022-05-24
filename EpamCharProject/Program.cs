using System;

namespace EpamCharProject
{
    //Написать программу, которая принимает из командной строки последовательность символов (строку) в качестве аргумента 
    // и выводит в консоль максимальное количество неодинаковых последовательных символов в строке
    class Program
    {
        static void Main()
        {
            bool endApp = false; 
            
            while (!endApp)
            {
                Console.WriteLine("Input string for search");
                string? str = Console.ReadLine();
                int count = 0;
                int countMax = 0;

                for (int i = 0; i < (str.Length - 1); i++) //(str.Length-1) - чтобы не выходить за пределы массива 
                {

                    if (str[i] == str[i + 1])
                    {
                        Console.WriteLine("SAME << {0} и {1} [Cчетчик: {2}, max:{3}]", str[i], str[i + 1], count, countMax);
                        if (count >= countMax)
                        {
                            countMax = count+1;
                            count = 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("DIFF >> {0} и {1} [Cчетчик: {2}, max:{3}]", str[i], str[i + 1], count, countMax);
                        count++;
                    }
                }
                if (count >= countMax)
                {
                    countMax = count+1;
                    count = 0;
                }

                Console.WriteLine("В строке {0}, кол-во max уник послед символов - {1}", str, countMax);

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing
            }
            return;
        }
    }
}
