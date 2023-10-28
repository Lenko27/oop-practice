using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.CoreEndurance;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Models.ShipSize;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Meridian : Ship
{
    public Meridian(int fuel)
    {
        ImpulseEngine = new ImpulseEngineClassE(fuel);
        IsNeutronDeflectorExist = true;
        Deflector = new DeflectorClass2();
        Endurance = new CoreClass2();
        Size = new MediumSize();
        Condition = ShipCondition.Alive;
        JumpingEngine = null;
    }
}