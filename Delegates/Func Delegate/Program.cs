using System;


public class Program
{
    static Func<int, int> _square;

    static int SquareMethod(int x) => x * x;

    static void Main(string[] args)
    {
        _square = null;

        int? result = _square?.Invoke(5);

        Console.WriteLine(result);

        Console.ReadKey();
    }
}
