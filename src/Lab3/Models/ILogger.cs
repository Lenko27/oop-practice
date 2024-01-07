namespace Itmo.ObjectOrientedProgramming.Lab3.Models;

public interface ILogger
{
    public void Debug(string message);
    public void Info(string message);
    public void Warning(string message);
    public void Err(string message);
}