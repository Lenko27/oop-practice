using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.RouteLen;

public class SmallLen : IRouteLen // 1 light year
{
    public int GetLen()
    {
        return 1;
    }
}