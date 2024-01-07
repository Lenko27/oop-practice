using Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Topics;

public class Topic : ITopic
{
    public Topic(string name, string header, Addressee addressee)
    {
        Name = name;
        Header = header;
        Addressee = addressee;
    }

    public string Name { get; }
    public string Header { get; }
    public Addressee Addressee { get; }

    public void SendMessage(Message message)
    {
        Addressee.AddMessage(message);
    }
}