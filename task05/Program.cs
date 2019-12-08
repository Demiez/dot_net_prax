using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
    /*
     05 Табл. 5.1 - Задачи на создание методов. При решении не использовать готовые строковые функции
     low - CompareStrings
     Написать метод, входными параметрами которого являются две строки. Метод должен вернуть 1, если в первой строке больше символов, 0, если в обеих строках равное количество символов, -1, если во второй строке больше символов.
     high - CompareChars
     Написать метод, входными параметрами которого являются две строки. Метод должен возвращать позицию первого вхождения в первую строку какого-либо символа из второй строки, либо -1, если первая строка не содержит ни одного символа, принадлежащего и второй строке. 
    */
    class Program
    {
        static void Main(string[] args)
        {
            string first = "first", second = "second", third = "third";
            Console.WriteLine($"Сравниваю строки {first} и {second} => {CompareStrings(first,second)}");
            Console.WriteLine($"Сравниваю символы {first} и {third} => {CompareChars(first, third)}");

            Console.ReadLine();
        }

        static int CompareStrings(string a, string b)
        {
            int GetLength(string str)
            {
                int counter = 0;
                foreach(char c in str)
                {
                    counter++;
                }
                return counter;
            }

            if (GetLength(a) > GetLength(b))
            {
                return 1;
            } else if (GetLength(a) == GetLength(b)) {
                return 0;
            } else
            {
                return -1;
            }
        }

        static int CompareChars(string a, string b)
        {
            int counter = 0, firstFound = -1;
            foreach(char c1 in a)
            {
                foreach(char c2 in b)
                {
                    if (c1 == c2 && firstFound == -1) firstFound = counter;
                }
                counter++;
            }
            return firstFound;
        }
    }
}
