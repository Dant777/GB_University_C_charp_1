using System;

namespace Lesson_7
{
  public static class MathTest
  {
    public static void Addition(float a, float b) => Console.WriteLine(string.Format("{0} + {1} = {2}", (object) a, (object) b, (object) (float) ((double) a + (double) b)));

        //Новый метод
        public static void Multiplication(float a, float b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }
  }
}
