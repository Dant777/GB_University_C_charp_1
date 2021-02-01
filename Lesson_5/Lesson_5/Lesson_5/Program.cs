using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.

 */
namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите чтонибуть :)");
            string userTxt = Console.ReadLine();
            string filename = "text.txt";

            File.WriteAllText(filename, userTxt);
            Console.WriteLine("Файл записан!");
            Console.ReadKey();
        }
    }
}
