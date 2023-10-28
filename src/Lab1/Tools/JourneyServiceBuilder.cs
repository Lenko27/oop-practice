using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Service;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tools;

public class JourneyServiceBuilder
{
    private readonly List<Ship> _ships;
    private Route? _route;
    private IDamageCalcTool? _damageCalcTool;
    private IFuelCalcTool? _fuelCalcTool;

    public JourneyServiceBuilder()
    {
        _ships = new List<Ship>();
    }

    public JourneyServiceBuilder SetRoute(Route route)
    {
        _route = route;
        return this;
    }

    public JourneyServiceBuilder SetDamageCalcTool(IDamageCalcTool damageCalcTool)
    {
        _damageCalcTool = damageCalcTool;
        return this;
    }

    public JourneyServiceBuilder SetFuelCalcTool(IFuelCalcTool fuelCalcTool)
    {
        _fuelCalcTool = fuelCalcTool;
        return this;
    }

    public JourneyServiceBuilder AddShip(Ship ship)
    {
        _ships.Add(ship);
        return this;
    }

    public JourneyService Build()
    {
        if (_route == null)
        {
            throw new BuilderException("route can't be null");
        }

        if (_damageCalcTool == null)
        {
            throw new BuilderException("damage calc tool can't be null");
        }

        if (_fuelCalcTool == null)
        {
            throw new BuilderException("fuel calc tool can't be null");
        }

        return new JourneyService(_route, _ships, _damageCalcTool, _fuelCalcTool);
    }
}