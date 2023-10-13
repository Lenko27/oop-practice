using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines.JumpingEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class ValkasWithPhotonDeflector : IShip
{
    public ValkasWithPhotonDeflector(int fuel)
    {
        ImpulseEngine = new ImpulseEngineClassE(fuel);
        JumpingEngine = new JumpingEngineGamma(fuel);
        Deflector = Deflectors.Photon;
        Endurance = CoreEndurance.Class2;
        Size = ShipSize.Medium;
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