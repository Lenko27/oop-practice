using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.SpaceTypes;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tools;

public class FuelCountTool : IFuelCalcTool
{
    public ResultOfJourney CalcFuel(IShip ship, RoutePart part)
    {
        if (ship == null)
        {
            throw new JourneyException("ship is null");
        }

        if (part == null)
        {
            throw new JourneyException("route part is null");
        }

        IEngine? engine = null;
        ISpaceType space = part.SpaceType;
        switch (space)
        {
            case NeutronParticlesNebula:
            {
                engine = ship.ImpulseEngine;
                if (engine is not ImpulseEngineClassE)
                {
                    return new ResultOfJourney(ShipCondition.Lost, 0, 0);
                }

                break;
            }

            case HighDensityNebula:
            {
                engine = ship.JumpingEngine;
                if (engine == null)
                {
                    return new ResultOfJourney(ShipCondition.Lost, 0, 0);
                }

                break;
            }

            case DefaultSpace:
                engine = ship.ImpulseEngine;
                break;
        }

        if (engine == null)
        {
            return new ResultOfJourney(ShipCondition.Lost, 0, 0);
        }

        return CalcFuel(engine, ship.Size, part.Len);
    }

    // читать документаци в файлах для понимания соотношения топлива, размера корабля и длины маршрута
    private static ResultOfJourney CalcFuel(IEngine engine, ShipSize size, RouteLen len)
    {
        int fuel = len switch
        {
            RouteLen.Small => 1,
            RouteLen.Medium => 10,
            RouteLen.Large => 100,
            _ => throw new ArgumentOutOfRangeException(nameof(len), len, null),
        };

        fuel *= size switch
        {
            ShipSize.Small => 1,
            ShipSize.Medium => 3,
            ShipSize.Big => 9,
            _ => throw new ArgumentOutOfRangeException(nameof(size), size, null),
        };
        int days = fuel; // соотношение размера корабля и длины маршрута
        switch (engine.FuelConsumption)
        {
            case FuelConsumption.Linear:
                fuel *= 1;
                break;
            case FuelConsumption.Log:
                fuel *= (int)Math.Log(fuel);
                break;
            case FuelConsumption.Square:
                fuel *= fuel;
                break;
        }

        if (fuel > engine.Fuel)
        {
            return new ResultOfJourney(ShipCondition.Lost, 0, 0);
        }

        engine.Fuel -= fuel;
        return new ResultOfJourney(ShipCondition.Alive, days, fuel);
    }
}