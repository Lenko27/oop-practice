using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Service;

public class JourneyService
{
    private readonly List<Ship> _ships;
    private Route _route;
    private IDamageCalcTool _damageCalc;
    private IFuelCalcTool _fuelCalc;

    internal JourneyService(Route route, IEnumerable<Ship> ships, IDamageCalcTool damageCalc, IFuelCalcTool fuelCalc)
    {
        _route = route;
        _damageCalc = damageCalc;
        _fuelCalc = fuelCalc;
        _ships = ships.ToList();
    }

    public IEnumerable<ResultOfJourney> InitiateJourney()
    {
        return _ships.Select(PushShipThroughRoute).ToList();
    }

    private ResultOfJourney PushShipThroughRoute(Ship ship)
    {
        int days = 0;
        int fuel = 0;
        foreach (RoutePart r in _route.Routes)
        {
            ShipCondition cond = _damageCalc.CalcDamage(ship, r.SpaceType);
            if (cond != ShipCondition.Alive)
            {
                return new ResultOfJourney(cond, 0, 0);
            }

            ResultOfJourney condition = _fuelCalc.CalcFuel(ship, r);
            if (condition.ShipCondition != ShipCondition.Alive)
            {
                return condition;
            }

            fuel += condition.UsedFuel;
            days += condition.DaysForJourney;
        }

        return new ResultOfJourney(ShipCondition.Alive, days, fuel);
    }
}