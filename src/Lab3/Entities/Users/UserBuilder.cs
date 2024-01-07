using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Users;

public class UserBuilder
{
    private string? _firstName;
    private string? _secondName;
    private DateTime _birthday;
    private string? _emailAddress;
    private string? _phoneNumber;

    public UserBuilder WithFirstName(string firstName)
    {
        _firstName = firstName;
        return this;
    }

    public UserBuilder WithSecondName(string secondName)
    {
        _secondName = secondName;
        return this;
    }

    public UserBuilder WithBirthday(DateTime birthday)
    {
        _birthday = birthday;
        return this;
    }

    public UserBuilder WithEmailAddress(string emailAddress)
    {
        _emailAddress = emailAddress;
        return this;
    }

    public UserBuilder WithPhoneNumber(string phoneNumber)
    {
        _phoneNumber = phoneNumber;
        return this;
    }

    public User Build()
    {
        if (string.IsNullOrEmpty(_firstName) || string.IsNullOrEmpty(_secondName) ||
            string.IsNullOrEmpty(_emailAddress) || string.IsNullOrEmpty(_phoneNumber))
        {
            throw new InvalidOperationException(
                "First Name, Second Name, Email Address, and Phone Number must be set before building the User.");
        }

        return new User(_firstName, _secondName, _birthday, _emailAddress, _phoneNumber);
    }
}