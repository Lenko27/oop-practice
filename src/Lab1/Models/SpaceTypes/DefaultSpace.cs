using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.SpaceTypes;

public class DefaultSpace : ISpaceType
{
    private readonly List<Obstacles> _obstacles;

    internal DefaultSpace(List<Obstacles> obstacles)
    {
        _obstacles = obstacles;
        CheckObstacles();
    }

    public IReadOnlyCollection<Obstacles> Obstacles => _obstacles;

    private void CheckObstacles()
    {
        if (_obstacles.Any(o => o is not Models.Obstacles.Asteroid and not Models.Obstacles.Meteorite))
        {
            throw new SpaceException("wrong obstacle for default space");
        }
    }
}