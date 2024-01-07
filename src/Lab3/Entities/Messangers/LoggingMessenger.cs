using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Messangers;

public class LoggingMessenger : IMessenger
{
    private readonly IMessenger _messenger;
    private readonly ILogger _logger;

    public LoggingMessenger(IMessenger messenger, ILogger logger)
    {
        _messenger = messenger;
        _logger = logger;
    }

    public IReadOnlyCollection<Message> Messages => _messenger.Messages;

    public void SendMessage(Message message)
    {
        _logger.Info("Message sent to messenger");
        _messenger.SendMessage(message);
    }
}