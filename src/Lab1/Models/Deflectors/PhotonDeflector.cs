using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;

public class PhotonDeflector : IDeflector
{
    private int _flashCount = 3;

    public Result AcceptDamage(AntimatterFlash antimatterFlash)
    {
        return Result.Rejected;
    }

    public Result AcceptDamage(Asteroid asteroid)
    {
        return Result.Rejected;
    }

    public Result AcceptDamage(Meteorite meteorite)
    {
        return Result.Rejected;
    }

    public Result AcceptDamage(SpaceWhale spaceWhale)
    {
        _flashCount--;
        return _flashCount < 0 ? Result.Rejected : Result.Accepted;
    }
}