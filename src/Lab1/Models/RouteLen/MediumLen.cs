using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.RouteLen;

public class MediumLen : IRouteLen // 10 light years
{
    public int GetLen()
    {
        return 10;
    }
}