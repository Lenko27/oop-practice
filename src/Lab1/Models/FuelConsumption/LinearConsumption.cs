using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.FuelConsumption;

public class LinearConsumption : IFuelConsumption
{
    public int GetCoefficient(int fuel)
    {
        return 1;
    }
}