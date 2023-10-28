using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tools;

public class DamageCalcTool : IDamageCalcTool
{
    public ShipCondition CalcDamage(Ship ship, ISpaceType space)
    {
        if (ship == null)
        {
            throw new JourneyException("ship is null");
        }

        if (space == null)
        {
            throw new JourneyException("space is null");
        }

        return CalcDamage(space.Obstacles, ship);
    }

    private static ShipCondition CalcDamage(
        IEnumerable<IObstacle> obstacles,
        Ship ship)
    {
        foreach (IObstacle o in obstacles)
        {
            o.AcceptShip(ship);
        }

        return ship.Condition;
    }
}