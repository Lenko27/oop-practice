using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Models.SpaceTypes;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tools.SpaceBuilders;

public class HighDensityNebulaBuilder
{
    private readonly List<IObstacle> _obstacles;

    public HighDensityNebulaBuilder()
    {
        _obstacles = new List<IObstacle>();
    }

    public HighDensityNebulaBuilder AddObstacle(AntimatterFlash obstacle)
    {
        _obstacles.Add(obstacle);
        return this;
    }

    public HighDensityNebula Build()
    {
        return new HighDensityNebula(_obstacles);
    }
}