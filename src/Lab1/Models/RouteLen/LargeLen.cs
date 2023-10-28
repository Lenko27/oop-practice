using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.RouteLen;

public class LargeLen : IRouteLen // 100 light years
{
    public int GetLen()
    {
        return 100;
    }
}