using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Meridian : IShip
{
    public Meridian(int fuel)
    {
        ImpulseEngine = new ImpulseEngineClassE(fuel);
        IsNeutronDeflectorExist = true;
        Deflector = Deflectors.Class2;
        Endurance = CoreEndurance.Class2;
        Size = ShipSize.Medium;
        Condition = ShipCondition.Alive;
        JumpingEngine = null;
    }

    public Deflectors Deflector { get; }
    public CoreEndurance Endurance { get; }
    public ShipSize Size { get; }
    public ShipCondition Condition { get; }
    public ImpulseEngine? ImpulseEngine { get; }
    public JumpingEngine? JumpingEngine { get; }
    public bool IsNeutronDeflectorExist { get; }
}