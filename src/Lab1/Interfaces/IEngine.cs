using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

public interface IEngine
{
    int Fuel { get; set; }
    FuelConsumption FuelConsumption { get; }
}