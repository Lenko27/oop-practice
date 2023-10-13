using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.JumpingEngines;

public class JumpingEngineGamma : JumpingEngine
{
    public JumpingEngineGamma(int fuel)
    {
        Fuel = fuel;
        FuelConsumption = FuelConsumption.Square;
    }
}