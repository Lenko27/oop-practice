using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.ImpulseEngines;

public class ImpulseEngineClassE : ImpulseEngine
{
    public ImpulseEngineClassE(int fuel)
    {
        Fuel = fuel;
        FuelConsumption = FuelConsumption.Log;
    }
}