using System;
using Itmo.ObjectOrientedProgramming.Lab3.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

public class MessageBuilder
{
    public string? Header { get; private set; }
    public DateTime DateTime { get; private set; }
    public string? Body { get; private set; }
    public ImportanceLevel? Importance { get; private set; }

    public MessageBuilder SetHeader(string header)
    {
        Header = header;
        return this;
    }

    public MessageBuilder SetDateTime(DateTime dateTime)
    {
        DateTime = dateTime;
        return this;
    }

    public MessageBuilder SetBody(string body)
    {
        Body = body;
        return this;
    }

    public MessageBuilder SetImportance(ImportanceLevel importance)
    {
        Importance = importance;
        return this;
    }

    public Message Build()
    {
        if (Header == null)
        {
            throw new ArgumentNullCorporativeException(nameof(Header));
        }

        if (Body == null)
        {
            throw new ArgumentNullCorporativeException(nameof(Body));
        }

        if (Importance == null)
        {
            throw new ArgumentNullCorporativeException(nameof(Importance));
        }

        return new Message(Header, Body, Importance, DateTime);
    }
}