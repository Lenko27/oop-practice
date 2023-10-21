using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.JumpingEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.CoreEndurance;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Models.ShipSize;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Valkas : Ship
{
    public Valkas(int fuel)
    {
        ImpulseEngine = new ImpulseEngineClassE(fuel);
        JumpingEngine = new JumpingEngineGamma(fuel);
        Deflector = new DeflectorClass1();
        Endurance = new CoreClass1();
        Size = new MediumSize();
        Condition = ShipCondition.Alive;
        IsNeutronDeflectorExist = false;
    }
}