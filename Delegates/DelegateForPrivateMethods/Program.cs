using System;

public delegate int AddDelegate(int a, int b);

public class Calculator
{
    private int _Add(int a, int b)
    {
        return a + b;
    }

    public AddDelegate GetAddDelegate()
    {
        return _Add;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        AddDelegate addDelegate = calc.GetAddDelegate();

        int result = addDelegate(5, 3);
        Console.WriteLine("Result: " + result);

        Console.ReadKey();
    }
}