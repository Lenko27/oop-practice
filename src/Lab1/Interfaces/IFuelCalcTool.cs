using Itmo.ObjectOrientedProgramming.Lab1.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

public interface IFuelCalcTool
{
    ResultOfJourney CalcFuel(IShip ship, RoutePart part);
}