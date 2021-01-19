using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *
 * Запросить у пользователя порядковый номер текущего месяца и вывести его название
 */
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int monthNumber = 0;
            bool isNumber = false;
            while (isNumber == false)
            {
                Console.WriteLine("Введите номер месяца:");

                if (!int.TryParse(Console.ReadLine(), out monthNumber) )
                {

                    Console.WriteLine("Введите число от 1 до 12");
                    Console.WriteLine("***********************************\n");
                    continue;
                }

                if (1 <= monthNumber && monthNumber <= 12 )
                {
                    isNumber = true;
                }
                else
                {
                    Console.WriteLine("Введите число от 1 до 12");
                    Console.WriteLine("***********************************\n");
                }

            }
            
            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("Выбранный месяц Январь");
                    break;
                case 2:
                    Console.WriteLine("Выбранный месяц Февраль");
                    break;
                case 3:
                    Console.WriteLine("Выбранный месяц Март");
                    break;
                case 4:
                    Console.WriteLine("Выбранный месяц Апрель");
                    break;
                case 5:
                    Console.WriteLine("Выбранный месяц Май");
                    break;
                case 6:
                    Console.WriteLine("Выбранный месяц Июнь");
                    break;
                case 7:
                    Console.WriteLine("Выбранный месяц Июль");
                    break;
                case 8:
                    Console.WriteLine("Выбранный месяц Август");
                    break;
                case 9:
                    Console.WriteLine("Выбранный месяц Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Выбранный месяц Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Выбранный месяц Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Выбранный месяц Декабрь");
                    break;
            }
            Console.ReadKey();

        }
    }
}
