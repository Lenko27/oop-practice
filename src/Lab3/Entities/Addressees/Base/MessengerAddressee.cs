using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messangers;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees.Base;

public class MessengerAddressee : Addressee
{
    private readonly IMessenger _messenger;
    private readonly List<Message> _messages = new();

    public MessengerAddressee(ImportanceLevel importanceLevel, IMessenger messenger)
        : base(importanceLevel)
    {
        _messenger = messenger;
    }

    public override void ReceiveMessages()
    {
        foreach (Message message in _messages)
        {
            _messenger.SendMessage(message);
        }
    }

    public override void AddMessage(Message message)
    {
        _messages.Add(message);
    }
}