using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Написать программу, которая при старте дописывает текущее время в файл «startup.txt»
 */
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "startup.txt";

            File.AppendAllText(filename, $"{DateTime.Now}");
            File.AppendAllText(filename, Environment.NewLine);

            string[] fileLines = File.ReadAllLines(filename);

            for (int i = 0; i < fileLines.Length; i++)
            {
                Console.WriteLine(fileLines[i]);
            }
            
            Console.ReadKey();

        }
    }
}
