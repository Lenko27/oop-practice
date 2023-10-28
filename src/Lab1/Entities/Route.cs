using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class Route
{
    private readonly List<RoutePart> _routes;

    internal Route(List<RoutePart> routes)
    {
        _routes = routes;
    }

    public IReadOnlyCollection<RoutePart> Routes => _routes;
}