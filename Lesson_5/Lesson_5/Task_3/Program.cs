using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/*
 Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
 */

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа от 0 до 255");
            string userByteStr = Console.ReadLine();
            byte[] writeUserByte = Regex.Matches(userByteStr, @"\d{1,3}").Cast<Match>()
                .Select(m => byte.Parse(m.Value))
                .ToArray();

            File.WriteAllBytes("bytes.bin", writeUserByte);

            Console.ReadKey();

        }
    }
}
