using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.SpaceTypes;

public class DefaultSpace : ISpaceType
{
    private readonly List<IObstacle> _obstacles;

    internal DefaultSpace(List<IObstacle> obstacles)
    {
        _obstacles = obstacles;
        CheckObstacles();
    }

    public IReadOnlyCollection<IObstacle> Obstacles => _obstacles;
    public IEngine? SelectEngine(ImpulseEngine? impulseEngine, JumpingEngine? jumpingEngine)
    {
        return impulseEngine;
    }

    private void CheckObstacles()
    {
        if (_obstacles.Any(o => o is not Models.Obstacles.Asteroid and not Models.Obstacles.Meteorite))
        {
            throw new SpaceException("wrong obstacle for default space");
        }
    }
}