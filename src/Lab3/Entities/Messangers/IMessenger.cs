using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Messangers;

public interface IMessenger
{
    IReadOnlyCollection<Message> Messages { get; }
    void SendMessage(Message message);
}
