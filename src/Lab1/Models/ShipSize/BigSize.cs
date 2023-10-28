using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.ShipSize;

public class BigSize : IShipSize
{
    public int GetCoefficient()
    {
        return 9;
    }
}