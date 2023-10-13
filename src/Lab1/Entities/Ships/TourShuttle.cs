using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class TourShuttle : IShip
{
    public TourShuttle(int fuel)
    {
        ImpulseEngine = new ImpulseEngineClassC(fuel);
        JumpingEngine = null;
        Deflector = Deflectors.None;
        Size = ShipSize.Small;
        Endurance = CoreEndurance.Class1;
        IsNeutronDeflectorExist = false;
        Condition = ShipCondition.Alive;
    }

    public Deflectors Deflector { get; }
    public CoreEndurance Endurance { get; }
    public ShipSize Size { get; }
    public ShipCondition Condition { get; }
    public ImpulseEngine? ImpulseEngine { get; }
    public JumpingEngine? JumpingEngine { get; }
    public bool IsNeutronDeflectorExist { get; }
}