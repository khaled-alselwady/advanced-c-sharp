using System;

public static class LogHandler
{
    public static void LogToDatabase(string message)
    {
        Console.WriteLine($"This error \"{message}\" will log to the database");
    }

    public static void LogToFile(string message)
    {
        Console.WriteLine($"This error \"{message}\" will log to the file");
    }
    public static void LogToScreen(string message)
    {
        Console.WriteLine(message);
    }
}