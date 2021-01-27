using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.
 * На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn.
 * Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень).
 * Используя эти методы, ввести с клавиатуры номер месяца и вывести название
 * времени года. Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
 */
namespace Task_3
{
    class Program
    {
        enum Season
        {
            None,
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int monthNumber = CheckMonthNamber();

                Season season = GetSeasonName(monthNumber);

                PrintSeasonName(season);
                Console.WriteLine("\n-------------------------------\n");
            }
            
        }

        static int CheckMonthNamber()
        {

            int monthNumber = 0;
            bool isNumber = false;

            while (isNumber == false)
            {
                Console.WriteLine("Введите номер месяца:");

                if (!int.TryParse(Console.ReadLine(), out monthNumber))
                {

                    Console.WriteLine("Ошибка, вы ввели не число");
                    Console.WriteLine("***********************************\n");
                    continue;
                }

                if (1 <= monthNumber && monthNumber <= 12)
                {
                    isNumber = true;
                    
                }
                else
                {
                    Console.WriteLine("Ошибка, введите число от 1 до 12");
                    Console.WriteLine("***********************************\n");
                }

            }
            return monthNumber;

        }

        static Season GetSeasonName(int monthNumber)
        {
            if (monthNumber == 12 || monthNumber == 1 || monthNumber == 2) return Season.Winter;
            else if (monthNumber == 3 || monthNumber == 4 || monthNumber == 5) return Season.Spring;
            else if (monthNumber == 6 || monthNumber == 7 || monthNumber == 8) return Season.Summer;
            else if (monthNumber == 9 || monthNumber == 10 || monthNumber == 11) return Season.Autumn;
            else return Season.None;
        }

        static void PrintSeasonName(Season season)
        {
            switch (season)
            {
                case Season.Winter:
                    Console.WriteLine("Зима");
                    break;
                case Season.Spring:
                    Console.WriteLine("Весна");
                    break;
                case Season.Summer:
                    Console.WriteLine("Лето");
                    break;
                case Season.Autumn:
                    Console.WriteLine("Осень");
                    break;
                case Season.None:
                    Console.WriteLine("Ошибка выбора месяца");
                    break;
            }
        }
    }
}
