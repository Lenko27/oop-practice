using System;
using System.Runtime.Serialization;

namespace Itmo.ObjectOrientedProgramming.Lab3.Exceptions;

public class ArgumentNullCorporativeException : CorporativeSystemException
{
    public ArgumentNullCorporativeException()
    {
    }

    public ArgumentNullCorporativeException(string? message)
        : base(message)
    {
    }

    public ArgumentNullCorporativeException(string? message, Exception? innerException)
        : base(message, innerException)
    {
    }

    protected ArgumentNullCorporativeException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}