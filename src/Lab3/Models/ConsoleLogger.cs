using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models;

public class ConsoleLogger : ILogger
{
    public void Debug(string message)
    {
        Console.WriteLine(ConstructLoggerMessage(DateTime.Now, message, "DEBUG"));
    }

    public void Info(string message)
    {
        Console.WriteLine(ConstructLoggerMessage(DateTime.Now, message, "INFO"));
    }

    public void Warning(string message)
    {
        Console.WriteLine(ConstructLoggerMessage(DateTime.Now, message, "WARD"));
    }

    public void Err(string message)
    {
        Console.WriteLine(ConstructLoggerMessage(DateTime.Now, message, "ERROR"));
    }

    private static string ConstructLoggerMessage(DateTime dateTime, string message, string level)
    {
        return $"[{dateTime}] - {level}: {message}";
    }
}