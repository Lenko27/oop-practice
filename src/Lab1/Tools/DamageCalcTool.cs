using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tools;

public class DamageCalcTool : IDamageCalcTool
{
    public ShipCondition CalcDamage(IShip ship, ISpaceType space)
    {
        if (ship == null)
        {
            throw new JourneyException("ship is null");
        }

        if (space == null)
        {
            throw new JourneyException("space is null");
        }

        return CalcDamage(space.Obstacles, ship.Deflector, ship.Endurance, ship.IsNeutronDeflectorExist);
    }

    private static ShipCondition CalcDamage(
        IEnumerable<Obstacles> obstacles,
        Deflectors deflector,
        CoreEndurance core,
        bool isAntiNeutron)
    {
        int asteroidCount = 0;
        int meteoritCount = 0;
        int whaleCount = 0;
        int antimatterCount = 0;
        switch (deflector)
        {
            case Deflectors.Class1:
                asteroidCount += 2;
                meteoritCount += 1;
                break;
            case Deflectors.Class2:
                asteroidCount += 10;
                meteoritCount += 3;
                break;
            case Deflectors.Class3:
                asteroidCount += 40;
                meteoritCount += 10;
                whaleCount += 1;
                break;
            case Deflectors.Photon:
                antimatterCount += 3;
                break;
        }

        switch (core)
        {
            case CoreEndurance.Class1:
                asteroidCount += 1;
                break;
            case CoreEndurance.Class2:
                asteroidCount += 5;
                meteoritCount += 2;
                break;
            case CoreEndurance.Class3:
                asteroidCount += 20;
                meteoritCount += 5;
                break;
        }

        foreach (Obstacles o in obstacles)
        {
            switch (o)
            {
                case Obstacles.AntimatterFlash:
                    antimatterCount--;
                    break;
                case Obstacles.Asteroid:
                    asteroidCount--;
                    break;
                case Obstacles.Meteorite:
                    meteoritCount--;
                    break;
                case Obstacles.SpaceWhale:
                    whaleCount--;
                    break;
            }
        }

        if (isAntiNeutron)
        {
            whaleCount = 0;
        }

        if (asteroidCount < 0 || whaleCount < 0 || meteoritCount < 0)
        {
            return ShipCondition.Exploded;
        }

        if (antimatterCount < 0)
        {
            return ShipCondition.PeopleDead;
        }

        return ShipCondition.Alive;
    }
}