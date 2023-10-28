using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.FuelConsumption;

public class SquareConsumption : IFuelConsumption
{
    public int GetCoefficient(int fuel)
    {
        return fuel;
    }
}