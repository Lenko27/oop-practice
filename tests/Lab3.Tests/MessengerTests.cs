using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees.Base;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees.Decorators;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Users;
using Itmo.ObjectOrientedProgramming.Lab3.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Moq;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class MessengerTests
{
    [Fact]
    public void UserWhenReceivesMessageStatusIsUnread()
    {
        var user = new User("John", "Doe", DateTime.Now, "john.doe@example.com", "123456");
        var message = new Message("Test header", "Test body", new ImportanceLevel(2), DateTime.Now);

        user.SendMessage(message);

        Assert.False(user.GetMessageStatus(message));
    }

    [Fact]
    public void UserWhenMarksUnreadMessageAsReadStatusChanges()
    {
        var user = new User("John", "Doe", DateTime.Now, "john.doe@example.com", "123456");
        var message = new Message("Test header", "Test body", new ImportanceLevel(2), DateTime.Now);
        user.SendMessage(message);

        user.MarkMessageAsRead(message);

        Assert.True(user.GetMessageStatus(message));
    }

    [Fact]
    public void UserWhenMarksReadMessageAsReadThrowsException()
    {
        var user = new User("John", "Doe", DateTime.Now, "john.doe@example.com", "123456");
        var message = new Message("Test header", "Test body", new ImportanceLevel(2), DateTime.Now);
        user.SendMessage(message);
        user.MarkMessageAsRead(message);

        Assert.Throws<CorporativeSystemException>(() => user.MarkMessageAsRead(message));
    }

    [Fact]
    public void UserAddresseeWhenFiltrationIsEnabledUnimportantMessageNotReceived()
    {
        var user = new User("John", "Doe", DateTime.Now, "john.doe@example.com", "123456");
        var addressee = new AddresseeWithFiltration(new UserAddressee(user, new ImportanceLevel(2)));
        var unimportantMessage =
            new Message("Unimportant header", "Unimportant body",  new ImportanceLevel(1), DateTime.Now);
        var importantMessage = new Message("Important header", "Important body",  new ImportanceLevel(3), DateTime.Now);

        addressee.AddMessage(unimportantMessage);
        addressee.AddMessage(importantMessage);
        addressee.ReceiveMessages();

        Assert.Single(user.Messages);
        Assert.Contains(importantMessage, user.Messages);
    }

    [Fact]
    public void LoggerAddresseeWhenReceivesMessagesLogsReceivedMessages()
    {
        var mockLogger = new Mock<ILogger>();
        var mockWrappedAddressee = new Mock<Addressee>(new ImportanceLevel(2));
        var loggerAddressee = new LoggerAddressee(mockWrappedAddressee.Object, mockLogger.Object);

        loggerAddressee.ReceiveMessages();

        mockLogger.Verify(x => x.Info(It.IsAny<string>()), Times.Once);
    }
}