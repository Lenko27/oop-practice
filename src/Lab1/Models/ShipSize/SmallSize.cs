using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.ShipSize;

public class SmallSize : IShipSize
{
    public int GetCoefficient()
    {
        return 1;
    }
}