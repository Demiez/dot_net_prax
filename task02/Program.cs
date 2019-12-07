using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    /*
    02 Табл. 2.1 - Вычислительные задачи 1
    low - CheckNumber01
    Дано натуральное число. Определить, есть ли в нем цифра а.
    mid - CheckNumber02
    Дано натуральное число. Определить, верно ли, что произведение его цифр меньше а, а само число делится на b?
    high - CheckNumber03
    Даны натуральные числа m и n. Получить все натуральные числа, меньшие n, квадрат суммы цифр которых равен m.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Проверям числа: ***");
            // Любой аргумент можно ввести из консоли используя блок кода, для ускорения аргументы прописаны
            /* Console.Write("number = ");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(number);
            */

            CheckNumber01(345, 3);
            CheckNumber02(34522456, 34523, 2);
            CheckNumber03(144, 94);

            Console.ReadLine();
        }

        static void CheckNumber01(int target, int a)
        {
            string stringNumber = target.ToString();
            if (stringNumber.IndexOf($"{a}") != -1)
            {
                Console.WriteLine($"Ваше число: {stringNumber} содержит {a}");
                return;
            }
            Console.WriteLine($"Ваше число: {stringNumber} не содержит {a}");
        }

        static void CheckNumber02(int target, int a, int b)
        {
            int[] resultArray = SplitIntoNumbers(target);
            int multiplyResult = 1;
            foreach (int element in resultArray)
            {
                multiplyResult *= element;
            }
            var result = (multiplyResult < a && multiplyResult % b == 0) ?
                $"Произведение цифр числа {target} равно {multiplyResult} ДА (меньше {a} и делится на {b})" :
                $"Произведение цифр числа {target} равно {multiplyResult} НЕТ (меньше {a} и делится на {b})";
            Console.WriteLine(result);
        }

        static int[] SplitIntoNumbers(int number)
        {
            List<int> numbersList = new List<int>();
            int basicDivider = 1, result = 0;

            do
            {
                result = (number / basicDivider) % 10;
                basicDivider *= 10;
                numbersList.Add(result);

            } while (result != 0);

            int[] resultArray = numbersList.ToArray();
            Array.Resize(ref resultArray, resultArray.Length - 1);

            return resultArray;
        }

        static void CheckNumber03(int m, int n)
        {
            Console.WriteLine($"Натуральные числа меньше {n}, квадрат суммы их цифр равен {m}:");
            for (int i = 1; i < n; i++)
            {
                int sum = 0, temp = i;
                do
                {
                    sum += temp % 10;
                    temp /= 10;
                }
                while (temp != 0);

                if (m == Math.Pow(sum, 2))
                    Console.WriteLine(i);
            }
        }
    }
}
