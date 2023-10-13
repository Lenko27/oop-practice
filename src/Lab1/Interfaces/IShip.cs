using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

public interface IShip
{
    public Deflectors Deflector { get; }
    public CoreEndurance Endurance { get; }
    public ShipSize Size { get; }
    public ShipCondition Condition { get; }

    /*
     * 1 с.г. = 1 ед. топлива
     * 10 c.л. = 10 ед. топлива
     * 100 с.л. = 100 ед. топлива
     */
    public ImpulseEngine? ImpulseEngine { get; }
    public JumpingEngine? JumpingEngine { get; }

    public bool IsNeutronDeflectorExist { get; }
}