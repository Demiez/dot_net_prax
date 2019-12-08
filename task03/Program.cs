using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    /*
    03 Табл. Задачи по обработке одномерных массивов
    low - FindAverageAndMin
    Найти в массиве среднее арифметическое и минимальное значения.
    mid - FindPairAndSwap
    Поменять местами в одномерном массиве противоположные по знаку элементы (например 5.7 и -5.7), с учетом перестановки каждого элемента не более одного раза.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 4, -5, 1 };
            double[] arrayWithPair = { 2, 3, 4, 2, -5.7, 4, 5, 1, 5.7, 3, 1 };

            FindAverageAndMin(array);
            FindPairAndSwap(arrayWithPair);

            Console.ReadLine();
        }

        static void FindAverageAndMin(int[] numbers)
        {
            int min = numbers[0], sum = 0;
            foreach (int elem in numbers)
            {
                sum += elem;
                if (min > elem) min = elem;
            }
            int avSum = sum / numbers.Length;
            Console.WriteLine("Среднее арифметическое массива: {0}, минимальное число: {1}", avSum, min);
        }

        static void FindPairAndSwap(double[] array)
        {
            Console.WriteLine("До перестановки: [{0}]", string.Join(", ", array));
            double El1 = 0, El2 = 0;
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (Math.Abs(array[i]) == Math.Abs(array[j]) && (array[i] < 0 || array[j] < 0))
                    {
                        El1 = array[i];
                        El2 = array[j];
                        array[i] = El2;
                        array[j] = El1;
                    }
                }
            }
            Console.WriteLine("После перестановки: [{0}]", string.Join(", ", array));
        }
    }
}
