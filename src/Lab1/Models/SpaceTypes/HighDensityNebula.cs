using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.SpaceTypes;

public class HighDensityNebula : ISpaceType
{
    private readonly List<Obstacles> _obstacles;

    internal HighDensityNebula(List<Obstacles> obstacles)
    {
        _obstacles = obstacles;
        CheckObstacles();
    }

    public IReadOnlyCollection<Obstacles> Obstacles => _obstacles;

    private void CheckObstacles()
    {
        if (_obstacles.Any(o => o is not Models.Obstacles.AntimatterFlash))
        {
            throw new SpaceException("wrong obstacle for high density nebula");
        }
    }
}