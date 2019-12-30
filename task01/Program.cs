using System;

namespace task01
{
    /*
     01 Табл. 1.1 - Задачи для индивидуального выполнения 1
     Предприниматель 1 марта открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается на 2% от имеющейся суммы. Определить  прирост суммы вклада за первый, второй, ..., десятый месяц.
    */
    class Program
    {
        static void Main(string[] args)
        {
            CalculateIncome(1000);
            Console.ReadLine();
        }

        static void CalculateIncome(int investment)
        {
            double income = investment;
            double incomePerMonth;
            Console.WriteLine("Ваш первоначальный вклад: {0}", income);

            for (int i = 0; i < 10; i++)
            {
                incomePerMonth = income * 0.02;
                income += incomePerMonth;
                Console.WriteLine("Прирост суммы за {0} месяц: {1}", i + 1, Math.Round(incomePerMonth, 2));
            }
        }
    }
}
