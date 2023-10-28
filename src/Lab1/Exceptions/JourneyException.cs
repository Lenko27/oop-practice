using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

public class JourneyException : Exception
{
    public JourneyException()
    {
    }

    public JourneyException(string message)
        : base(message)
    {
    }

    public JourneyException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}