using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * «Морской бой» — вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.
 */
namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] battelfield = CreateArray();
            
            //#1
            AddShipInBattleField(0,0,1, 1, battelfield);
            AddShipInBattleField(0, 9, 1, 1, battelfield);
            AddShipInBattleField(9, 9, 1, 1, battelfield);
            AddShipInBattleField(9, 0, 1, 1, battelfield);

            //#2
            AddShipInBattleField(2, 0, 1, 2, battelfield);
            AddShipInBattleField(3, 7, 2, 2, battelfield);
            AddShipInBattleField(5, 6, 2, 2, battelfield);

            //#3
            AddShipInBattleField(3, 2, 2, 3, battelfield);
            AddShipInBattleField(7, 2, 1, 3, battelfield);

            //#3
            AddShipInBattleField(0, 3, 2, 4, battelfield);

            PrintField(battelfield);
            Console.ReadKey();

        }


        static string[,] CreateArray()
        {
            string [,] battelfield = new string[10,10];
            

            for (int i = 0; i < battelfield.GetLength(0); i++)
            {
                for (int j = 0; j < battelfield.GetLength(1); j++)
                {
                    battelfield[i, j] = "-";
                }
            }

            return battelfield;
        }

        static void PrintField(string[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0, 2}",arr[i, j]);
                }
                Console.Write("{0, 2}","|");
                Console.Write("\n");
            }
        }
        /// <summary>
        /// Добавление корабля на поле
        /// </summary>
        /// <param name="vertIndex">вертикальный индекс поля</param>
        /// <param name="horizntIndex">Горизонтальный индекс поля</param>
        /// <param name="direction"> 1 - вертикальное расположение; 2 - горизонтальное расположение</param>
        /// <param name="shipLen">Длина корабля</param>
        /// <param name="battelfield">Поле</param>
        static void AddShipInBattleField(int vertIndex, int horizntIndex, int direction, int shipLen, string[,] battelfield)
        {

            for (int i = 0; i < shipLen; i++)
            {
                
                battelfield[vertIndex, horizntIndex] = "X";
                if (direction == 1)
                {
                    vertIndex++;
                }
                else
                {
                    horizntIndex++;
                }
                
            }
        }

     
    }
}
