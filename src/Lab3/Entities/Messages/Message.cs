using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

public class Message : IEquatable<Message>
{
    public Message(string header, string body, ImportanceLevel importanceLevel, DateTime dateTime)
    {
        Header = header;
        Body = body;
        Importance = importanceLevel;
        DateTime = dateTime;
    }

    public string Header { get; }
    public DateTime DateTime { get; }
    public string Body { get; }
    public ImportanceLevel Importance { get; }

    public bool Equals(Message? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Header == other.Header && DateTime.Equals(other.DateTime) && Body == other.Body &&
               Importance.Equals(other.Importance);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((Message)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Header, DateTime, Body, Importance);
    }
}