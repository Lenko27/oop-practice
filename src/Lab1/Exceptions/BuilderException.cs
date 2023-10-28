using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

public class BuilderException : Exception
{
    public BuilderException()
    {
    }

    public BuilderException(string message)
        : base(message)
    {
    }

    public BuilderException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}