using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Запросить у пользователя минимальную и
 * максимальную температуру за сутки и вывести среднесуточную температуру.
 */
namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double minTemperature = 0;
            bool isNumMinTemp = false;
            while (isNumMinTemp == false)
            {
                Console.WriteLine("Введите минимальную температуру за сутки:");
                if (double.TryParse(Console.ReadLine(), out minTemperature))
                {
                    isNumMinTemp = true;
                }
                else
                {
                    Console.WriteLine("Введите число!");
                    Console.WriteLine("***********************************\n");
                }
               
            }
            
            double maxTemperature = 0;
            bool isNumMaxTemp = false;

            while (isNumMaxTemp == false)
            {
                Console.WriteLine("Введите максимальную температуру за сутки:");
                if (double.TryParse(Console.ReadLine(), out maxTemperature))
                {
                    isNumMaxTemp = true;
                }
                else
                {
                    Console.WriteLine("Введите число!");
                    Console.WriteLine("***********************************\n");
                }

            }

            double averageNumber = (minTemperature + maxTemperature) / 2;
            Console.WriteLine($"Средне суточная температура: {averageNumber}");

            Console.ReadKey();
        }
    }
}
