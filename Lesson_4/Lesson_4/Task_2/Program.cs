using System;
/*
 * Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом,
 * и возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести результат на экран.
 */
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа:");
            string strNumbers = Console.ReadLine();

            Sum(strNumbers);

            Console.ReadKey();
        }

        static void Sum(string numbers)
        {
            string[] words = numbers.Split(new char[] { ' ' });
            double sum = 0;
            foreach (string s in words)
            {
                sum += Convert.ToInt16(s);
                
            }
            Console.Write($"\n");

            Console.Write($"Сумма: {sum}");
        }
    }
}
