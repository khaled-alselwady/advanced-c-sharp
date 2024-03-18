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
    static void Main(string[] args)
    {
        Logger loggerToScreen = new Logger(null);
        Logger loggerToDatabase = new Logger(LogHandler.LogToDatabase);
        Logger loggerToFile = new Logger(LogHandler.LogToFile);

        loggerToScreen.Log("Screen Error");
        loggerToDatabase.Log("Database Error");
        loggerToFile.Log("File Error");

        Console.ReadKey();
    }
}

