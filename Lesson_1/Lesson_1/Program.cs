using System;

/*
 * ЗАДАНИЕ:
 * Написать программу, выводящую в консоль текст: «Привет, %имя пользователя%, сегодня %дата%».
 * Имя пользователя сохранить из консоли в промежуточную переменную.
 * Поставить точку останова и посмотреть значение этой переменной в режиме отладки.
 * Запустить исполняемый файл через системный терминал.
 *
 */
namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите имя:");
            string userName = Console.ReadLine();

            Console.WriteLine($"Привет, {userName}, сегодня {DateTime.Now.ToShortDateString()}");

            Console.ReadKey();

        }
    }
}
