using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Users;

public interface IUser
{
    string FirstName { get; }
    string SecondName { get; }
    DateTime Birthday { get; }
    string EmailAddress { get; }
    string PhoneNumber { get; }
    IReadOnlyCollection<Message> Messages { get; }
    void SendMessage(Message message);
    void MarkMessageAsRead(Message message);
}
