using System;
/*
 Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет завершить указанный процесс. 
Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса.
В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.
 */
namespace Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Команды:");
            UserInput user = new UserInput();
            bool exitFlag = true;
            string userCommand;
            while (exitFlag) 
            {
                Console.WriteLine("Ввудите команду:");
                
                userCommand = Console.ReadLine();
                user.UserCommandManager(userCommand);

                exitFlag = user.GetExitFlag;
            }
            
        }
    }
}
