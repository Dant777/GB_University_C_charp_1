using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *
 * Написать программу, выводящую введенную пользователем строку в обратном порядке (olleH вместо Hello).
 */
namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string taskTxt = "olleH";
            Console.WriteLine($"{taskTxt} - {ReversString(taskTxt)}");

            Console.WriteLine("Введите текст:");
            
            string txt = Console.ReadLine();
            Console.WriteLine($"{txt} - {ReversString(txt)}");
            Console.ReadKey();

        }

        static string ReversString(string txt)
        {
            string reversTxt = "";
            for (int i = txt.Length - 1; i >= 0; i--)
            {
                reversTxt += txt[i];
            }

            return reversTxt;
        }
    }
}
