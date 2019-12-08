using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task04
{
    /*
    Табл. 4.1 - Задачи по обработке двумерных массивов. При решении задачи предусмотреть вывод массива в виде таблицы (каждую строку таблицы отделять при выводе на экран переводом на новую строку).
    low - DisplayEvenArray
    Вывести двумерный массив в виде таблицы: четные элементы выводить на своем месте в таблице, прибавив к значению 1, нечетные - выводить пробелы вместо элемента.
    high - ParseMatrix
    Дана двумерная квадратная матрица. Вычислить сумму тех из ее элементов, расположенных на главной диагонали и выше нее, которые превосходят по величине все элементы, расположенные ниже главной диагонали. Если на главной диагонали и выше нее нет элементов с указанным свойством, то ответом должно служить сообщение об этом.
    */

    class Program
    {
        static void Main(string[] args)
        {
            int[,] newMatrix = CreateAndFillTheArray(5, 5);
            DisplayArray(newMatrix);

            DisplayArray(CreateAndFillTheArray(5, 5));
            DisplayEvenArray(CreateAndFillTheArray(8, 8));

            // В аргументах к GenerateRandomMatrix (кол-во рядов, кол-во колонок, максим. число для рэндома)
            int[,] randomMatrix = GenerateRandomMatrix(5, 5, 12);
            ParseMatrix(randomMatrix);



            Console.ReadLine();
        }

        static int[,] CreateAndFillTheArray(int x, int y)
        {
            int[,] myArray;
            myArray = new int[x, y];

            for(int i = 0; i < x; i++)
            {
                for(int j = 0; j < y; j++)
                {
                    myArray[i, j] = i * j;
                }
            }

            return myArray;
        }

        static void DisplayArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void DisplayEvenArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j % 2 == 0) Console.Write((array[i, j] + 1) + "\t");
                    if (j % 2 != 0) Console.Write(" " + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static int[,] GenerateRandomMatrix(int x, int y, int z)
        {
            var random = new Random();
            int[,] myMatrix;
            myMatrix = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    myMatrix[i, j] = random.Next(0, z);
                }
            }

            return myMatrix;
        }

        static void ParseMatrix (int[,] array)
        {
            DisplayArray(array);
            int maxNumBelow = 0, sum = 0;
            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[i, j] > maxNumBelow) maxNumBelow = array[i, j];
                }
            }
            
            for (int i = 0; i< array.GetLength(0); i++)
            {
                for (int j = i; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > maxNumBelow) sum += array[i, j];
                }
            }

            Console.WriteLine("Максимальная величина ниже гл. диагонали: {0}", maxNumBelow);
            string answer = sum == 0 ?
                $"НЕТ таких элементов на главной диагонали и выше, которые больше величины ниже диагонали" :
                $"Cумма элементов на гл. диагонали и выше, которые больше величины ниже диагонали: {sum}";
            Console.WriteLine(answer);
        }
    }
}
