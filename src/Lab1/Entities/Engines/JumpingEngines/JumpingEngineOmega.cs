using Itmo.ObjectOrientedProgramming.Lab1.Models.FuelConsumption;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.JumpingEngines;

public class JumpingEngineOmega : JumpingEngine
{
    public JumpingEngineOmega(int fuel)
    {
        Fuel = fuel;
        FuelConsumption = new LogConsumption();
    }
}