using Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Topics;

public class TopicWithLogger : ITopic
{
    private readonly ILogger _logger;
    private readonly ITopic _topic;

    public TopicWithLogger(ILogger logger, ITopic topic)
    {
        _logger = logger;
        _topic = topic;
        Name = topic.Name;
        Header = topic.Header;
        Addressee = topic.Addressee;
    }

    public string Name { get; }
    public string Header { get; }
    public Addressee Addressee { get; }

    public void SendMessage(Message message)
    {
        _logger.Info("Message sent to Addressee");
        _topic.SendMessage(message);
    }
}