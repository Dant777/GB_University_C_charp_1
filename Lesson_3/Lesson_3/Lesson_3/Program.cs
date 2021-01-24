using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Написать программу, выводящую элементы двухмерного массива по диагонали.
 */
namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int n = Convert.ToInt16(Console.ReadLine());
            int [,] arr = new int[n, n];
            
            GenerateArr(arr);
            Console.ReadKey();

        }

        private static void GenerateArr(int[,] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("|");

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j == counter)
                    {
                        Console.Write(" X ");
                    }
                    else
                    {
                        Console.Write(" 0 ");
                    }
                   
                }
                Console.Write("|\n");
                counter++;
            }
        }
    }
}
