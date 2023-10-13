using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

public abstract class ImpulseEngine : IEngine
{
    public int Fuel { get; set; }
    public FuelConsumption FuelConsumption { get; protected set; }
}