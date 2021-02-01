using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/**
 * Написать метод GetFullName(string firstName, string lastName, string patronymic),
 * принимающий на вход ФИО в разных аргументах и возвращающий
 * объединённую строку с ФИО. Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО
 */
namespace Task_1
{
    
    class Program
    {
        private static string[] firstNameArr = new[] {"Петр", "Алексей", "Сергей", "Олег", "Юрий", "Генадий", "Александр"};
        private static string[] lastNameArr = new[] { "Алексеев", "Петров", "Смирнов", "Корев", "Маркин", "Самин", "Осипов" };
        private static string[] patronymicArr = new[] { "Алексеевич", "Петрович", "Сереевич", "Юрьевич", "Александрович", "Викторович", "Осипов" };
        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";
            string patronymic = "";
            string fullName = "";
            for (int i = 0; i < 4; i++)
            {
                 firstName = GetRndStirng(firstNameArr);
                  lastName = GetRndStirng(lastNameArr);
                 patronymic = GetRndStirng(patronymicArr);
                 fullName = GetFullName(firstName, lastName, patronymic);
                
                Console.WriteLine(fullName);

            }

            Console.WriteLine();

            Console.ReadKey();
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"Full name is: {firstName} {lastName} {patronymic}";
        }

        static string GetRndStirng(string[] stringArr)
        {
            Random rnd = new Random();
            int rndIndex = rnd.Next(0, stringArr.Length);
            return stringArr[rndIndex];
        }
    }
}
