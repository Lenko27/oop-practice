using System;
using System.Runtime.Serialization;

namespace Itmo.ObjectOrientedProgramming.Lab3.Exceptions;

public class CorporativeSystemException : Exception
{
    public CorporativeSystemException()
    {
    }

    public CorporativeSystemException(string? message)
        : base(message)
    {
    }

    public CorporativeSystemException(string? message, Exception? innerException)
        : base(message, innerException)
    {
    }

    protected CorporativeSystemException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}