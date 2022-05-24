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
                int count = 0;
                int countMax = 0;

                for (int i = 0; i < (str.Length - 1); i++) //(str.Length-1) - чтобы не выходить за пределы массива 
                {

                    if (str[i] == str[i + 1])
                    {
                        Console.WriteLine("SAME << {0} и {1} [Counter: {2}, max: {3}]", str[i], str[i + 1], count, countMax);
                        if (count >= countMax) // Записываем счетчик в Макс и обнуляем счетчик
                        {
                            countMax = count+1; // +1 чтобы учитывать переходной символ
                            count = 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("DIFF >> {0} и {1} [Counter: {2}, max: {3}]", str[i], str[i + 1], count, countMax);
                        count++;
                    }
                }
                if (count >= countMax)
                {
                    countMax = count+1; // +1 чтобы считать последний уникальный символ
                }

                Console.WriteLine("В строке {0}, кол-во макс уник послед символов - {1}", str, countMax);

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
