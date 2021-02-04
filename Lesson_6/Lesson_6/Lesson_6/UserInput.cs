using System;

namespace Lesson_6
{
    public class UserInput
    {

        private bool _exitFlag = true;

        public UserInput()
        {
            PrintHelp();
        }

        public bool GetExitFlag { get => _exitFlag; }

        public void UserCommandManager(string userCommand)
        {
            string command = GetCommand(userCommand);

            switch (command)
            {
                case "!help":
                    PrintHelp();
                    break;
                case "!ppr":
                    TaskManager.PrintProceses();
                    break;
                case "!prl":
                    TaskManager.PrintProcesesLenght();
                    break;
                case "!killid":
                    TaskManager.KillProcesesById(GetIdCommand(userCommand));
                    break;
                case "!exit":
                    _exitFlag = false;
                    break;
                case "!error":
                    Console.WriteLine($"\n{userCommand} - Такой команды нет! Попробуйте еще раз\n");
                    Console.WriteLine("----------------------------------\n");
                    break;
                default:
                    Console.WriteLine($"\n{userCommand} - Такой команды нет! Попробуйте еще раз\n");
                    Console.WriteLine("----------------------------------\n");
                    break;
            }

        }

        private void PrintHelp()
        {
            Console.WriteLine("----------------------------------\n");

            Console.WriteLine("\t!help - печать всех команд");
            Console.WriteLine("\t!ppr - печать всех процессов");
            Console.WriteLine("\t!prl - количество процессов");
            Console.WriteLine("\t!killid <id> - завершение процесса по id");
            Console.WriteLine("\t!exit - выход из программы");

            Console.WriteLine("\n----------------------------------\n");
        }

        private string GetCommand(string userCommand)
        {
            if (userCommand.Contains("!help"))
            {
                return "!help";
            } 
            else if(userCommand.Contains("!ppr"))
            {
                return "!ppr";
            }
            else if (userCommand.Contains("!prl"))
            {
                return "!prl";
            }
            else if (userCommand.Contains("!killid"))
            {
                return "!killid";
            }
            else if (userCommand.Contains("!exit"))
            {
                return "!exit";
            }

            return "!error";
        }

        private int GetIdCommand(string userCommand)
        {
            
            string[] userStr = userCommand.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (!int.TryParse(userStr[1], out int commandId))
            {
                Console.WriteLine($"Не верный ID {commandId}");
            }

            return commandId;

        }
    }
}
