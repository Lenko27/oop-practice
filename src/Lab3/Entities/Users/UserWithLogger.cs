using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Users;

public class UserWithLogger : IUser
{
    private readonly IUser _user;
    private readonly ILogger _logger;

    public UserWithLogger(IUser user, ILogger logger)
    {
        _user = user;
        _logger = logger;
    }

    public string FirstName => _user.FirstName;
    public string SecondName => _user.SecondName;
    public DateTime Birthday => _user.Birthday;
    public string EmailAddress => _user.EmailAddress;
    public string PhoneNumber => _user.PhoneNumber;
    public IReadOnlyCollection<Message> Messages => _user.Messages;

    public void SendMessage(Message message)
    {
        _logger.Info($"{FirstName} {SecondName} sent a message: {message}");
        _user.SendMessage(message);
    }

    public void MarkMessageAsRead(Message message)
    {
        _logger.Info($"{FirstName} {SecondName} read a message: {message}");
        _user.MarkMessageAsRead(message);
    }
}