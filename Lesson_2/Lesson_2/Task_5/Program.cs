using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима»
 */
namespace Task_5
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

                if (!int.TryParse(Console.ReadLine(), out monthNumber))
                {

                    Console.WriteLine("Введите число от 1 до 12");
                    Console.WriteLine("***********************************\n");
                    continue;
                }

                if (1 <= monthNumber && monthNumber <= 12)
                {
                    isNumber = true;
                }
                else
                {
                    Console.WriteLine("Введите число от 1 до 12");
                    Console.WriteLine("***********************************\n");
                }

            }

            double temperature = 0;
            isNumber = false;
            while (isNumber == false)
            {
                Console.WriteLine("Введите температу месяца:");

                if (
                    double.TryParse(Console.ReadLine(), out temperature))
                {

                    isNumber = true;

                }
                else
                {
                    Console.WriteLine("Введите число");
                    Console.WriteLine("***********************************\n");
                }

            }

            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("Выбранный месяц Январь");
                    if(temperature > 0)
                        Console.WriteLine("Дождливая зима");
                    break;
                case 2:
                    Console.WriteLine("Выбранный месяц Февраль");
                    if (temperature > 0)
                        Console.WriteLine("Дождливая зима");
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
                    if (temperature > 0)
                        Console.WriteLine("Дождливая зима");
                    break;
                default:
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
