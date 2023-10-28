using System.Diagnostics;
using Itmo.ObjectOrientedProgramming.Lab1.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tools;

public class FuelCountTool : IFuelCalcTool
{
    public ResultOfJourney CalcFuel(Ship ship, RoutePart part)
    {
        if (ship == null)
        {
            throw new JourneyException("ship is null");
        }

        if (part == null)
        {
            throw new JourneyException("route part is null");
        }

        IEngine? engine = part.SpaceType.SelectEngine(ship.ImpulseEngine, ship.JumpingEngine);

        if (engine == null)
        {
            return new ResultOfJourney(ShipCondition.Lost, 0, 0);
        }

        return CalcFuel(engine, ship.Size ?? throw new JourneyException("ship size is null"), part.Len);
    }

    // читать документаци в файлах для понимания соотношения топлива, размера корабля и длины маршрута
    private static ResultOfJourney CalcFuel(IEngine engine, IShipSize size, IRouteLen len)
    {
        int fuel = len.GetLen();

        fuel *= size.GetCoefficient();
        int days = fuel; // соотношение размера корабля и длины маршрута
        Debug.Assert(engine.FuelConsumption != null, "engine.FuelConsumption != null");
        fuel *= engine.FuelConsumption.GetCoefficient(fuel);

        if (fuel > engine.Fuel)
        {
            return new ResultOfJourney(ShipCondition.Lost, 0, 0);
        }

        engine.SetFuel(engine.Fuel - fuel);
        return new ResultOfJourney(ShipCondition.Alive, days, fuel);
    }
}