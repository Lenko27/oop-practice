using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees.Decorators;

public class AddresseeWithFiltration : Addressee
{
    private readonly Addressee _wrappedAddressee;

    public AddresseeWithFiltration(Addressee wrappedAddressee)
        : base(wrappedAddressee.ImportanceLevel)
    {
        _wrappedAddressee = wrappedAddressee;
    }

    public override void AddMessage(Message message)
    {
        if (message.Importance.Level > _wrappedAddressee.ImportanceLevel.Level)
        {
            _wrappedAddressee.AddMessage(message);
        }
    }

    public override void ReceiveMessages()
    {
        _wrappedAddressee.ReceiveMessages();
    }
}