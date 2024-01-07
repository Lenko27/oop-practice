using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Displays;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees.Base;

public class DisplayAddressee : Addressee
{
    private readonly DisplayDriver _displayDriver;
    private Message? _message;

    public DisplayAddressee(DisplayDriver displayDriver, ImportanceLevel importanceLevel)
        : base(importanceLevel)
    {
        _displayDriver = displayDriver;
    }

    public override void ReceiveMessages()
    {
        ArgumentNullException.ThrowIfNull(_message);
        _displayDriver.ShowMessage(_message);
    }

    public override void AddMessage(Message message)
    {
        _message = message;
    }
}