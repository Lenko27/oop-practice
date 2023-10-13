using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class RoutePart
{
    public RoutePart(ISpaceType spaceType, RouteLen len)
    {
        SpaceType = spaceType;
        Len = len;
    }

    public ISpaceType SpaceType { get; }

    public RouteLen Len { get; }
}