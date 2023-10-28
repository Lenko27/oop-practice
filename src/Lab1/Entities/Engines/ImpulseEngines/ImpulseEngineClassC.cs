using Itmo.ObjectOrientedProgramming.Lab1.Models.FuelConsumption;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.ImpulseEngines;

public class ImpulseEngineClassC : ImpulseEngine
{
    public ImpulseEngineClassC(int fuel)
    {
        Fuel = fuel;
        FuelConsumption = new LinearConsumption();
    }
}