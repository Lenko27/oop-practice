using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;

public abstract class Addressee
{
    protected Addressee(ImportanceLevel importanceLevel)
    {
        ImportanceLevel = importanceLevel;
    }

    public ImportanceLevel ImportanceLevel { get; }
    public abstract void ReceiveMessages();
    public abstract void AddMessage(Message message);
}