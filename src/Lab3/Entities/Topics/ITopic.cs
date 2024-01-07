using Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Topics;

public interface ITopic
{
    public string Name { get; }
    public string Header { get; }
    public Addressee Addressee { get; }
    public void SendMessage(Message message);
}