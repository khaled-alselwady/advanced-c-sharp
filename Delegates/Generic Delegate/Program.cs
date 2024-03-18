using System;
using System.Collections.Generic;

namespace Generic_Delegate
{
    internal class Program
    {
        //public delegate bool Filter<in T>(T number);

        static void Main(string[] args)
        {
            IEnumerable<int> list1 = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            PrintNumbersWhere(list1, number => number % 2 == 0, () => Console.WriteLine("Even Numbers:"));
            PrintNumbersWhere(list1, number => number % 2 != 0, () => Console.WriteLine("Odd Numbers:"));
            PrintNumbersWhere(list1, number => number > 5, () => Console.WriteLine("Great than 5:"));

            Console.ReadKey();
        }

        static void PrintNumbersWhere<T>(IEnumerable<T> list, Predicate<T> filter, Action message)
        {
            if (list is null || filter is null || message is null) return;

            message();

            foreach (T number in list)
            {
                if (filter(number))
                    Console.Write(number + " ");
            }

            Console.WriteLine();
        }

    }
}
