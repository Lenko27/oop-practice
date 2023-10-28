using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

public interface IDeflector
{
    Result AcceptDamage(AntimatterFlash antimatterFlash);
    Result AcceptDamage(Asteroid asteroid);
    Result AcceptDamage(Meteorite meteorite);
    Result AcceptDamage(SpaceWhale spaceWhale);
}