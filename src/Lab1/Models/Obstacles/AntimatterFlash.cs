using System;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class AntimatterFlash : IObstacle
{
    public void AcceptShip(Ship ship)
    {
        ArgumentNullException.ThrowIfNull(ship);
        ship.AcceptObstacle(this);
    }
}