using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.JumpingEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.CoreEndurance;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Models.ShipSize;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Avgur : Ship
{
    public Avgur(int fuel)
    {
        Deflector = new DeflectorClass3();
        ImpulseEngine = new ImpulseEngineClassE(fuel);
        JumpingEngine = new JumpingEngineAlpha(fuel);
        Endurance = new CoreClass3();
        Size = new BigSize();
        Condition = ShipCondition.Alive;
        IsNeutronDeflectorExist = false;
    }
}