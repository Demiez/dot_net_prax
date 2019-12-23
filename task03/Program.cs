using System;

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
            double[] array = { 2, 3, 4, -5, 1, 2};
            // double[] arrayWithPair = { 2, 3, 4, 2, -5.7, 4, 5, 1, 5.7, 3, 1 };

            double[] checkArray = { 2, -2, -2, 2, -3, -3, 3, 3, 5.7, 1 };

            FindAverageAndMin(array);
            FindPairAndSwap(checkArray);

            Console.ReadLine();
        }

        static void FindAverageAndMin(double[] numbers)
        {
            double min = numbers[0], sum = 0;
            foreach (double elem in numbers)
            {
                sum += elem;
                if (min > elem) min = elem;
            }
            double avSum = sum / numbers.Length;
            Console.WriteLine("Среднее арифметическое массива: {0}, минимальное число: {1}", avSum, min);
        }

        static void FindPairAndSwap(double[] array)
        {
            object[] usedArray = new object[array.Length]; // Создаем зеркальный массив подобной длины, но тип данных объект, тк может принимать любые значения
            double pass = double.NaN; // добавим значение плейсхолдер, чтобы отметить измененные ячейки, нан не равен нан;

            Console.WriteLine("До перестановки: [{0}]", string.Join(", ", array));
            double El1 = 0, El2 = 0;
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (Math.Abs(array[i]) == Math.Abs(array[j]) && ((array[i] < 0 && array[j] > 0) || (array[i] > 0 && array[j] < 0)))
                    {
                        El1 = array[i];
                        El2 = array[j];
                        usedArray[i] = El2; // меняем местами и заносим в зеркальный массив
                        usedArray[j] = El1;
                        array[i] = pass;
                        array[j] = pass;
                        break;
                    }
                }
                usedArray[i] = usedArray[i] == null ? array[i] : usedArray[i];
            }
            array = Array.ConvertAll<object, double>(usedArray, x => (double)x);
            Console.WriteLine("После перестановки: [{0}]", string.Join(", ", array));
        }
    }
}
