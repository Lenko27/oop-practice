using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.CoreEndurance;

public class CoreClass3 : ICoreEndurance
{
    private int _asteroidCount = 20;
    private int _meteoriteCount = 5;

    public Result AcceptDamage(Asteroid asteroid)
    {
        _asteroidCount--;
        return _asteroidCount < 0 ? Result.Rejected : Result.Accepted;
    }

    public Result AcceptDamage(Meteorite meteorite)
    {
        _meteoriteCount--;
        return _meteoriteCount < 0 ? Result.Rejected : Result.Accepted;
    }
}