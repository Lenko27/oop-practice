using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees.Base;

public class GroupAddressee : Addressee
{
    private readonly List<Addressee> _addressees = new();
    private readonly List<Message> _messages = new();

    public GroupAddressee(ImportanceLevel importanceLevel)
        : base(importanceLevel)
    {
    }

    public void AddRecipient(Addressee addressee)
    {
        _addressees.Add(addressee);
    }

    public override void ReceiveMessages()
    {
        foreach (Addressee recipient in _addressees)
        {
            foreach (Message message in _messages)
            {
                recipient.AddMessage(message);
                recipient.ReceiveMessages();
            }
        }
    }

    public override void AddMessage(Message message)
    {
        _messages.Add(message);
    }
}