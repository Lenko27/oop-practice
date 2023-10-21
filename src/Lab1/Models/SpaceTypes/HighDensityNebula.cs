using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.SpaceTypes;

public class HighDensityNebula : ISpaceType
{
    private readonly List<IObstacle> _obstacles;

    internal HighDensityNebula(List<IObstacle> obstacles)
    {
        _obstacles = obstacles;
        CheckObstacles();
    }

    public IReadOnlyCollection<IObstacle> Obstacles => _obstacles;
    public IEngine? SelectEngine(ImpulseEngine? impulseEngine, JumpingEngine? jumpingEngine)
    {
        return jumpingEngine;
    }

    private void CheckObstacles()
    {
        if (_obstacles.Any(o => o is not Models.Obstacles.AntimatterFlash))
        {
            throw new SpaceException("wrong obstacle for high density nebula");
        }
    }
}