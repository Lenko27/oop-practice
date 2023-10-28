using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Models.SpaceTypes;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tools.SpaceBuilders;

public class NeutronParticlesNebulaBuilder
{
    private readonly List<IObstacle> _obstacles;

    public NeutronParticlesNebulaBuilder()
    {
        _obstacles = new List<IObstacle>();
    }

    public NeutronParticlesNebulaBuilder AddObstacle(SpaceWhale obstacle)
    {
        _obstacles.Add(obstacle);
        return this;
    }

    public NeutronParticlesNebula Build()
    {
        return new NeutronParticlesNebula(_obstacles);
    }
}