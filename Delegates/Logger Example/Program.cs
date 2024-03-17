using System;

public class Logger
{
    public delegate void LogAction(string message);
    private LogAction _logAction;

    public Logger(LogAction logAction)
    {
        _logAction = logAction;
    }

    public void Log(string message)
    {
        _logAction?.Invoke(message);
    }
}
public class Program
{
    static void LogToScreen(string message)
    {
        Console.WriteLine(message);
    }

    static void LogToDatabase(string message)
    {
        Console.WriteLine($"This error \"{message}\" will log to the database");
    }

    static void LogToFile(string message)
    {
        Console.WriteLine($"This error \"{message}\" will log to the file");
    }

    static void Main(string[] args)
    {
        Logger loggerToScreen = new Logger(null);
        Logger loggerToDatabase = new Logger(LogToDatabase);
        Logger loggerToFile = new Logger(LogToFile);

        loggerToScreen.Log("Screen Error");
        loggerToDatabase.Log("Database Error");
        loggerToFile.Log("File Error");

        Console.ReadKey();
    }
}

