using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Users;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees.Base;

public class UserAddressee : Addressee
{
    private readonly User _user;
    private readonly List<Message> _messages = new();

    public UserAddressee(User user, ImportanceLevel importanceLevel)
        : base(importanceLevel)
    {
        _user = user;
    }

    public IReadOnlyCollection<Message> Messages => _messages;

    public override void ReceiveMessages()
    {
        foreach (Message message in _messages)
        {
            _user.SendMessage(message);
        }
    }

    public override void AddMessage(Message message)
    {
        _messages.Add(message);
    }
}