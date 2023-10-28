using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.JumpingEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.CoreEndurance;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Models.ShipSize;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class ValkasWithPhotonDeflector : Ship
{
    public ValkasWithPhotonDeflector(int fuel)
    {
        ImpulseEngine = new ImpulseEngineClassE(fuel);
        JumpingEngine = new JumpingEngineGamma(fuel);
        Deflector = new PhotonDeflector();
        Endurance = new CoreClass2();
        Size = new MediumSize();
        Condition = ShipCondition.Alive;
        IsNeutronDeflectorExist = false;
    }
}