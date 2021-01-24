using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий список
 * телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/e-mail.
 *
 */
namespace Task_2
{
    class Program
    {
        private static string[] nameCollection = new[] { "Jaime Banks", "Dai Finley", "Cthulhu", "Ciaran Baldwin", "Ginger West", "Lev Johnson", "Cameron Nguyen", "Lavinia Downs", "Joel Oconnor", "Matthew Velazquez" };
        private static string[] phoneCollection = new[]
        {
            "006-722-5314/vulputate.nisi@diam.edu", "072-532-1027/lorem.luctus.ut@nuncac.net",
            "071-016-3552/nunc@eumetusIn.org",
            "043-577-0347/nec.urna@Namporttitor.edu", "099-983-0199/pede@lacinia.net",
            "086-762-8577/montes@luctusaliquetodio.com", "086-762-8577/Aliquam@atpretiumaliquet.co.uk"
        };

        static void Main(string[] args)
        {
            
            string[,] arr = new string[5, 2];
            GenerateArrNamePhone(arr);

            Console.ReadKey();
        }


        private static void GenerateArrNamePhone(string[,] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1) ; j++)
                {
                    if (j == 0)
                    {
                        arr[i, j] = nameCollection[rnd.Next(0, nameCollection.Length)];
                    }
                    else
                    {
                        arr[i, j] = phoneCollection[rnd.Next(0, phoneCollection.Length)]; ;
                    }
                    
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                
                Console.WriteLine($"Name: {arr[i,0]};\t Phone: {arr[i, 1]}");
                
            }
        }
    }
}
