using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * (*) Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом. 
 */
namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }

            Console.ReadKey();
        }

        static int Fibonacci(int number)
        {
            if (number == 0)
                return 0; 
            if (number == 1)
                return 1; 
            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
    }
}
