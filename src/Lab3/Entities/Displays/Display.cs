namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Displays;

public class Display
{
    public Display(string message)
    {
        Message = message;
    }

    public string Message { get; internal set; }
}