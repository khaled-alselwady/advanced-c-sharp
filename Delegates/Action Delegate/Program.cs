using System;


public class Program
{
    static void ActionWithParameterlessMethod()
    {
        Console.WriteLine("This is a parameterless method");
    }

    static void ActionWithIntParameter(int x)
    {
        Console.WriteLine($"Action with int parameter: {x}");
    }

    static void ActionWithMultipleParameters(string str, int x)
    {
        Console.WriteLine($"Action with Multiple parameters: {str},{x}");
    }

    static void Main(string[] args)
    {
        Action actionWithParameterlessMethod = ActionWithParameterlessMethod;
        Action<int> actionWithIntParameter = ActionWithIntParameter;
        Action<string, int> actionWithMultipleParameters = ActionWithMultipleParameters;

        actionWithParameterlessMethod?.Invoke();
        actionWithIntParameter?.Invoke(5);
        actionWithMultipleParameters?.Invoke("Hello, World!", 5);

        Console.ReadKey();
    }
}