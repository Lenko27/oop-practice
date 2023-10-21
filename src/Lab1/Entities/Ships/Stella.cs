using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.JumpingEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.CoreEndurance;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Models.ShipSize;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Stella : Ship
{
    public Stella(int fuel)
    {
        ImpulseEngine = new ImpulseEngineClassC(fuel);
        JumpingEngine = new JumpingEngineOmega(fuel);
        Deflector = new DeflectorClass1();
        Endurance = new CoreClass1();
        Size = new SmallSize();
        Condition = ShipCondition.Alive;
        IsNeutronDeflectorExist = false;
    }
}