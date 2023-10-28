using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class RoutePart
{
    public RoutePart(ISpaceType spaceType, IRouteLen len)
    {
        SpaceType = spaceType;
        Len = len;
    }

    public ISpaceType SpaceType { get; }

    public IRouteLen Len { get; }
}