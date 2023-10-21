using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;

public class DeflectorClass3 : IDeflector
{
    private int _asteroidCount = 40;
    private int _meteoriteCount = 10;
    private int _whaleCount = 1;

    public Result AcceptDamage(AntimatterFlash antimatterFlash)
    {
        return Result.Rejected;
    }

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

    public Result AcceptDamage(SpaceWhale spaceWhale)
    {
        _whaleCount--;
        return _whaleCount < 0 ? Result.Rejected : Result.Accepted;
    }
}