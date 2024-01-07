using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Displays;

public class DisplayDriver
{
    public DisplayDriver(Display display, ConsoleColor color)
    {
        Display = display;
        Color = color;
    }

    public Display Display { get; }

    public ConsoleColor Color { get; private set; }

    public void ShowMessage(Message message)
    {
        Console.ForegroundColor = Color;
        Display.Message = message.Body;
        Console.WriteLine($"Display: {message.Body}");
    }

    public void SetTextColor(ConsoleColor color)
    {
        Color = color;
    }
}