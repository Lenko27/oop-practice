using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.JumpingEngines;

public class JumpingEngineOmega : JumpingEngine
{
    public JumpingEngineOmega(int fuel)
    {
        Fuel = fuel;
        FuelConsumption = FuelConsumption.Log;
    }
}