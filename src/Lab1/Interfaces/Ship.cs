using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;
namespace Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

public abstract class Ship
{
    public IDeflector? Deflector { get; protected set; }
    public ICoreEndurance? Endurance { get; protected set; }
    public IShipSize? Size { get; protected set; }
    public ShipCondition Condition { get; protected set; }

    /*
     * 1 с.г. = 1 ед. топлива
     * 10 c.л. = 10 ед. топлива
     * 100 с.л. = 100 ед. топлива
     */
    public ImpulseEngine? ImpulseEngine { get; protected set; }
    public JumpingEngine? JumpingEngine { get; protected set; }

    public bool IsNeutronDeflectorExist { get; protected set; }

    public void AcceptObstacle(AntimatterFlash antimatterFlash)
    {
        if (Deflector == null)
        {
            Condition = ShipCondition.PeopleDead;
            return;
        }

        if (Deflector.AcceptDamage(antimatterFlash) == Result.Rejected)
        {
            Condition = ShipCondition.PeopleDead;
        }
    }

    public void AcceptObstacle(Asteroid asteroid)
    {
        if (Deflector == null)
        {
            if (Endurance?.AcceptDamage(asteroid) == Result.Rejected)
            {
                Condition = ShipCondition.Exploded;
            }

            return;
        }

        if (Deflector.AcceptDamage(asteroid) == Result.Rejected &&
            Endurance?.AcceptDamage(asteroid) == Result.Rejected)
        {
            Condition = ShipCondition.Exploded;
        }
    }

    public void AcceptObstacle(Meteorite meteorite)
    {
        if (Deflector == null)
        {
            if (Endurance?.AcceptDamage(meteorite) == Result.Rejected)
            {
                Condition = ShipCondition.Exploded;
            }

            return;
        }

        if (Deflector.AcceptDamage(meteorite) == Result.Rejected &&
            Endurance?.AcceptDamage(meteorite) == Result.Rejected)
        {
            Condition = ShipCondition.Exploded;
        }
    }

    public void AcceptObstacle(SpaceWhale spaceWhale)
    {
        if (IsNeutronDeflectorExist)
        {
            return;
        }

        if (Deflector == null)
        {
            Condition = ShipCondition.Exploded;
            return;
        }

        if (Deflector.AcceptDamage(spaceWhale) == Result.Rejected)
        {
            Condition = ShipCondition.Exploded;
        }
    }
}