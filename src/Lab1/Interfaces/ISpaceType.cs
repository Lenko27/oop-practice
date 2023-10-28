using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

public interface ISpaceType
{
    IReadOnlyCollection<IObstacle> Obstacles { get; }

    IEngine? SelectEngine(ImpulseEngine? impulseEngine, JumpingEngine? jumpingEngine);
}