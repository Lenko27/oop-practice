using Itmo.ObjectOrientedProgramming.Lab1.Models.FuelConsumption;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.JumpingEngines;

public class JumpingEngineAlpha : JumpingEngine
{
    public JumpingEngineAlpha(int fuel)
    {
        Fuel = fuel;
        FuelConsumption = new LinearConsumption();
    }
}