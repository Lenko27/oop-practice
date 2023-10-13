using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tools;

public class RouteBuilder
{
    private readonly List<RoutePart> _routes = new List<RoutePart>();

    public RouteBuilder()
    {
    }

    public RouteBuilder AddRoute(RoutePart routePart)
    {
        _routes.Add(routePart);
        return this;
    }

    public Route Build()
    {
        return new Route(_routes);
    }
}