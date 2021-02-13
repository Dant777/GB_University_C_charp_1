using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {

            MathTest.Addition(2, 3);
            
            Console.ReadKey();

        }

    }

    public static class MathTest
    {
        public static void Addition(float a, float b) 
        {

            Console.WriteLine($"{a} + {b} = {a + b}");
        }

    }
}
