using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Определить, является ли введённое пользователем число чётным.
 */
namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber = 0;
            bool isNumber = false;
            while (isNumber == false)
            {
                Console.WriteLine("Введите цифру:");

                if (
                    int.TryParse(Console.ReadLine(), out userNumber))
                {

                    isNumber = true;
                   
                }
                else
                {
                    Console.WriteLine("Введите число");
                    Console.WriteLine("***********************************\n");
                }

            }

            int number = userNumber % 2;

            if (number == 0)
            {
                Console.WriteLine($"{userNumber} - Число четное");
            }
            else
            {
                Console.WriteLine($"{userNumber} - Число не четное");
            }
            
            Console.ReadKey();
        }
    }
}
