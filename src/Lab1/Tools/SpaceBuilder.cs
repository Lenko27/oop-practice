using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.SpaceTypes;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tools;

public class SpaceBuilder
{
    private SpaceType? _spaceType;
    private List<IObstacle> _obstacles;

    public SpaceBuilder()
    {
        _obstacles = new List<IObstacle>();
    }

    public SpaceBuilder SetSpaceType(SpaceType spaceType)
    {
        _spaceType = spaceType;
        return this;
    }

    public SpaceBuilder AddObstacle(IObstacle obstacle)
    {
        _obstacles.Add(obstacle);
        return this;
    }

    public ISpaceType Build()
    {
        ISpaceType space = _spaceType switch
        {
            SpaceType.DefaultSpace => new DefaultSpace(_obstacles),
            SpaceType.HighDensityNebula => new HighDensityNebula(_obstacles),
            SpaceType.NeutronParticlesNebula => new NeutronParticlesNebula(_obstacles),
            null => throw new BuilderException("space type hasn't been chosen"),
            _ => throw new ArgumentOutOfRangeException(),
        };

        return space;
    }
}