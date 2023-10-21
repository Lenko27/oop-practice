using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.CoreEndurance;
using Itmo.ObjectOrientedProgramming.Lab1.Models.ShipSize;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class TourShuttle : Ship
{
    public TourShuttle(int fuel)
    {
        ImpulseEngine = new ImpulseEngineClassC(fuel);
        JumpingEngine = null;
        Deflector = null;
        Size = new SmallSize();
        Endurance = new CoreClass1();
        IsNeutronDeflectorExist = false;
        Condition = ShipCondition.Alive;
    }
}