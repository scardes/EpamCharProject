using System;

namespace EpamCharProject
{
    //Программа, которая принимает из командной строки последовательность символов (строку) в качестве аргумента 
    //и выводит в консоль максимальное количество неодинаковых последовательных символов в строке
    class Program
    {
        static void Main()
        {
            bool endApp = false;

            while (!endApp) //Повторять программу пока не получим ключ "n"
            {
                Console.WriteLine("Enter a string to search for a sequence of unique characters");
                string? str = Console.ReadLine(); // "?" Вопрос чтобы принимал значение null - при вводе строки

                //string uniqueStringMax = FindUnique(str);

                Console.WriteLine("\nMAX unique symbols is: {0}", FindUnique(str)); //
                Console.WriteLine("------------------------\n");

                Console.Write("Press 'n' and Enter to close the app, or press any key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;
                Console.WriteLine("\n"); // Friendly linespacing
            }
            return;


            string FindUnique(string inputLine)
            {
                string unicStr = "";
                string unicStrMax = "";
                string unicStrMaxTemp = "";

                if (inputLine.Length == 1) unicStrMax = inputLine; //Если введен один символ

                for (int i = 0; i < (inputLine.Length - 1); i++) //(str.Length-1) - чтобы не выходить за пределы массива 
                {
                    if (inputLine[i] != inputLine[i + 1]) // If symbols NOT is equal //Цикл сравнения символов
                    {
                        //Console.WriteLine("DIFF >> {0} и {1} ", inputLine[i], inputLine[i + 1]); // For debug 
                        unicStr += inputLine[i]; //Записываем текущий символ
                        unicStrMaxTemp = unicStr + inputLine[i + 1]; //Записываем след сравнимаемый символ 
                    }

                    else
                    {
                        //Console.WriteLine("SAME << {0} и {1} ", inputLine[i], inputLine[i + 1]); // For debug Начинаем собирать новую строку
                        unicStr = "";
                        unicStrMaxTemp = "";
                    }

                    if (unicStrMaxTemp.Length == 0) unicStrMaxTemp += inputLine[0]; // Если все символы одинаковые. 

                    if (unicStrMaxTemp.Length > unicStrMax.Length) unicStrMax = unicStrMaxTemp; // Сравниваем Врем.макс с основным > Макс символоми Переписываем Макс если Темп больше
                   
                }

                return unicStrMax;
            }
        }
    }
}