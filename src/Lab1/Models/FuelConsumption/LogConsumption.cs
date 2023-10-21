using System;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.FuelConsumption;

public class LogConsumption : IFuelConsumption
{
    public int GetCoefficient(int fuel)
    {
        return (int)Math.Log(fuel);
    }
}