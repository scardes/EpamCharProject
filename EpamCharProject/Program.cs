using System;

namespace EpamCharProject
{
    //Написать программу, которая принимает из командной строки последовательность символов (строку) в качестве аргумента 
    //и выводит в консоль максимальное количество неодинаковых последовательных символов в строке
    class Program
    {
        static void Main()
        {
            bool endApp = false; 
            
            while (!endApp) //Повторять программу пока не получим ключ "n"
            {
                Console.WriteLine("Введите строку для поиска в ней последовательность уникальных символов");
                string? str = Console.ReadLine(); // "?" Вопрос чтобы принимал значение null - при вводе строки
                string unicStr = "";
                string unicStrMax = "";
                string unicStrMaxTemp = "";
                //int count = 0;
                //int countMax = 0;

                for (int i = 0; i < (str.Length - 1); i++) //(str.Length-1) - чтобы не выходить за пределы массива 
                {
                    if (str[i] != str[i + 1]) // If symbols NOT is equal //Цикл сравнения символов
                    {
                        Console.WriteLine("DIFF >> {0} и {1} ", str[i], str[i + 1]);
                        unicStr = unicStr + str[i]; //Записываем текущий символ
                        unicStrMaxTemp = unicStr + str[i+1]; //Записываем след сравнимаемый символ 
                        if (unicStrMaxTemp.Length > unicStrMax.Length) // Сравниваем Врем.макс с основным Макс символоми
                        {
                            unicStrMax = unicStrMaxTemp; // Переписываем Макс если Темп больше
                        }
                    }
                    else
                    {
                        Console.WriteLine("SAME << {0} и {1} ", str[i], str[i + 1]);
                        // символы похожи сохраняем текущую макс строку и начинаем собирать новую строку
                        unicStrMax = unicStrMaxTemp; //Записываем след сравнимаемый символ 
                        unicStr = "";
                        unicStrMaxTemp = "";
                    }
                }  


                Console.WriteLine("MAX unic symbols - {0}",  unicStrMax);

                Console.WriteLine("------------------------\n");
                
                // Wait for the user to respond before closing.
                Console.Write("Нажмите 'n' и Enter чтобы выйти из программы, или введите любое значение и Enter для продолжения работы с программой: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing
            }
            return;
        }
    }
}
