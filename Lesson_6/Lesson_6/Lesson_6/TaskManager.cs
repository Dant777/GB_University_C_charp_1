using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    public static class TaskManager
    {
       
        public static void PrintProceses()
        {
            Process[] processses = Process.GetProcesses();
            Console.WriteLine("");
            for (int i = 0; i < processses.Length; i++)
            {
                Console.WriteLine($"#{i + 1}; ID - {processses[i].Id}; Name - {processses[i].ProcessName}");
            }
            Console.WriteLine("\n----------------------------------\n");
        }

        public static void PrintProcesesLenght()
        {
            Process[] processses = Process.GetProcesses();
            Console.WriteLine($"\nКоличество процессов - {processses.Length}");
            Console.WriteLine("\n----------------------------------\n");
        }

        public static void KillProcesesById(int processId)
        {
            if (processId == 0)
            {
                return;
            }
            Process processses = Process.GetProcessById(processId);
            processses.Kill();
            Console.WriteLine($"\nВыход программы завершен!");
            Console.WriteLine("\n----------------------------------\n");
        }
    }
}
