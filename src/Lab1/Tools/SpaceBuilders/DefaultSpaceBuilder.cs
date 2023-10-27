using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Models.SpaceTypes;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tools.SpaceBuilders;

public class DefaultSpaceBuilder
{
    private readonly List<IObstacle> _obstacles;

    public DefaultSpaceBuilder()
    {
        _obstacles = new List<IObstacle>();
    }

    public DefaultSpaceBuilder AddObstacle(Asteroid obstacle)
    {
        _obstacles.Add(obstacle);
        return this;
    }

    public DefaultSpaceBuilder AddObstacle(Meteorite obstacle)
    {
        _obstacles.Add(obstacle);
        return this;
    }

    public DefaultSpace Build()
    {
        return new DefaultSpace(_obstacles);
    }
}