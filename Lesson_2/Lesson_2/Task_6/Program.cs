using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Для полного закрепления битовых масок, попытайтесь создать универсальную структуру расписания недели,
 * к примеру, чтобы описать работу какого либо офиса. Явный пример - офис номер 1 работает со вторника до пятницы,
 * офис номер 2 работает с понедельника до воскресенья
 */
namespace Task_6
{
    class Program
    {
        [Flags]
        public enum DayOfWeekMask
        {

            Monday = 0b_1000000,
            Tuesday = 0b_0100000,
            Wednesday = 0b_0010000,
            Thursday = 0b_0001000,
            Friday = 0b_0000100,
            Saturday = 0b_0000010,
            Sunday = 0b_0000001,

        }
        static void Main(string[] args)
        {

            
            

            int weekNumber = 0;
            bool isNumber = false;
            while (isNumber == false)
            {
                Console.WriteLine("Введите номер месяца:");

                if (!int.TryParse(Console.ReadLine(), out weekNumber))
                {

                    Console.WriteLine("Введите число от 1 до 7");
                    Console.WriteLine("***********************************\n");
                    continue;
                }

                if (1 <= weekNumber && weekNumber <= 7)
                {
                    isNumber = true;
                }
                else
                {
                    Console.WriteLine("Введите число от 1 до 7");
                    Console.WriteLine("***********************************\n");
                }

            }

            DayOfWeekMask workScheduleMask = DayOfWeekMask.Monday | DayOfWeekMask.Tuesday | DayOfWeekMask.Thursday | DayOfWeekMask.Wednesday | DayOfWeekMask.Friday;
            switch (weekNumber)
            {
                case 1:
                    Console.WriteLine("Выбранный день недели - Понедельник");
                    CheckWorkDay("Компания №1", workScheduleMask, DayOfWeekMask.Monday);
                    break;
                case 2:
                    Console.WriteLine("Выбранный день недели - Вторник");
                    CheckWorkDay("Компания №1", workScheduleMask, DayOfWeekMask.Tuesday);
                    break;
                case 3:
                    Console.WriteLine("Выбранный день недели - Среда");
                    CheckWorkDay("Компания №1", workScheduleMask, DayOfWeekMask.Wednesday);
                    break;
                case 4:
                    Console.WriteLine("Выбранный день недели - Четверг");
                    CheckWorkDay("Компания №1", workScheduleMask, DayOfWeekMask.Thursday);
                    break;
                case 5:
                    Console.WriteLine("Выбранный день недели - Пятница");
                    CheckWorkDay("Компания №1", workScheduleMask, DayOfWeekMask.Friday);
                    break;
                case 6:
                    Console.WriteLine("Выбранный день недели - Суббота");
                    CheckWorkDay("Компания №1", workScheduleMask, DayOfWeekMask.Saturday);
                    break;
                case 7:
                    Console.WriteLine("Выбранный день недели - Воскресение");
                    CheckWorkDay("Компания №1", workScheduleMask, DayOfWeekMask.Sunday);
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }

        public static void CheckWorkDay(string companiName, DayOfWeekMask workScheduleMask, DayOfWeekMask dayOfWeekMask)
        {
            DayOfWeekMask workDay = dayOfWeekMask & workScheduleMask;
           
            if (workDay == dayOfWeekMask)
            {
                Console.WriteLine($"{companiName} работает в этот день");
            }
            else
            {
                Console.WriteLine($"{companiName} не работает в этот день");
            }
        }
    }
}
