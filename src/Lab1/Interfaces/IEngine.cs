namespace Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

public interface IEngine
{
    int Fuel { get; }
    IFuelConsumption? FuelConsumption { get; }

    void SetFuel(int fuel);
}