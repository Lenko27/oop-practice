using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.JumpingEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Stella : IShip
{
    public Stella(int fuel)
    {
        ImpulseEngine = new ImpulseEngineClassC(fuel);
        JumpingEngine = new JumpingEngineOmega(fuel);
        Deflector = Deflectors.Class1;
        Endurance = CoreEndurance.Class1;
        Size = ShipSize.Small;
        Condition = ShipCondition.Alive;
        IsNeutronDeflectorExist = false;
    }

    public Deflectors Deflector { get; }
    public CoreEndurance Endurance { get; }
    public ShipSize Size { get; }
    public ShipCondition Condition { get; }
    public ImpulseEngine? ImpulseEngine { get; }
    public JumpingEngine? JumpingEngine { get; }
    public bool IsNeutronDeflectorExist { get; }
}