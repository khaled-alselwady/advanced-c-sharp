using System;


public class Program
{
    static Predicate<int> _IsEvenPredicate = IsEven;

    static bool IsEven(int x) => (x % 2 == 0);

    static void Main(string[] args)
    {
        bool? result = _IsEvenPredicate?.Invoke(4);

        Console.WriteLine(result);

        Console.ReadKey();
    }
}

