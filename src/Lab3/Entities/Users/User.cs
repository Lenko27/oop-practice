using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Exceptions;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Users;

public class User : IUser, IEquatable<User>
{
    private readonly Dictionary<Message, bool> _messages = new();

    public User(string firstName, string secondName, DateTime birthday, string emailAddress, string phoneNumber)
    {
        FirstName = firstName;
        SecondName = secondName;
        Birthday = birthday;
        EmailAddress = emailAddress;
        PhoneNumber = phoneNumber;
    }

    public string FirstName { get; }
    public string SecondName { get; }
    public DateTime Birthday { get; }
    public string EmailAddress { get; }
    public string PhoneNumber { get; }
    public IReadOnlyCollection<Message> Messages => _messages.Keys;

    public void SendMessage(Message message)
    {
        ArgumentNullException.ThrowIfNull(message);
        if (_messages.ContainsKey(message))
        {
            throw new ArgumentNullException(nameof(message));
        }

        _messages.Add(message, false);
    }

    public void MarkMessageAsRead(Message message)
    {
        ArgumentNullException.ThrowIfNull(message);

        if (_messages[message])
        {
            throw new CorporativeSystemException("Message already read");
        }

        _messages[message] = true;
    }

    public bool GetMessageStatus(Message message)
    {
        return _messages[message];
    }

    public bool Equals(User? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return _messages.Equals(other._messages) && FirstName == other.FirstName &&
               SecondName == other.SecondName && Birthday.Equals(other.Birthday) &&
               EmailAddress == other.EmailAddress && PhoneNumber == other.PhoneNumber;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((User)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_messages, FirstName, SecondName, Birthday, EmailAddress, PhoneNumber);
    }
}