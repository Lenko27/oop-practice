using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

public abstract class JumpingEngine : IEngine
{
    public int Fuel { get; protected set; }
    public IFuelConsumption? FuelConsumption { get; protected set; }
    public void SetFuel(int fuel)
    {
        Fuel = fuel;
    }
}