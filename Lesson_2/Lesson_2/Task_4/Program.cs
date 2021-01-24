using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли,
 * только за место динамических, по вашему мнению, данных (это может быть дата, название магазина, сумма покупок)
 * подставляйте переменные, которые были заранее заготовлены до вывода на консоль
 */
namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "OOO \"ЧТО ТО\"";
            string txt_1 = "ККМ 00000   ИНН 0000000";
            string txt_2 = "КАСИР №1";
            int number_1 = 2998;
            int number_2 = 777;
            double number_3 = 1377.01;

            Console.WriteLine($"\t{title}");
            Console.WriteLine($"{txt_1}");
            Console.WriteLine($"{DateTime.Now}  \t{txt_2}");
            Console.WriteLine($"ПРОДАЖА \t\t N{number_1}");
            Console.WriteLine($"00 \t\t\t ={number_2}");
            Console.WriteLine($"ВКЛЮЧАЯ НАЛОГИ");
            Console.WriteLine($"НДС 18.00% \t\t ={number_3}");
            Console.WriteLine($"СУММА НАЛОГА \t\t ={number_3}");
            Console.WriteLine($"ИТОГ \t\t\t ={number_2}");
            Console.WriteLine($"НАЛИЧНЫМИ \t\t ={number_2}");
            Console.WriteLine($"-------------------------------------");
            Console.ReadKey();
        }
    }
}
