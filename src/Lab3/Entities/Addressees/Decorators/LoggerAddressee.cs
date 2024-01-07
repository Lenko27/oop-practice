using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees.Decorators;

public class LoggerAddressee : Addressee
{
    private readonly Addressee _wrappedAddressee;
    private readonly ILogger _logger;

    public LoggerAddressee(Addressee wrappedAddressee, ILogger logger)
        : base(wrappedAddressee.ImportanceLevel)
    {
        _wrappedAddressee = wrappedAddressee ?? throw new ArgumentNullException(nameof(wrappedAddressee));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public override void ReceiveMessages()
    {
        _logger.Info("Messages received");
        _wrappedAddressee.ReceiveMessages();
    }

    public override void AddMessage(Message message)
    {
        _logger.Info("Message added");
        _wrappedAddressee.AddMessage(message);
    }
}