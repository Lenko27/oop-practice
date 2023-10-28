using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

public interface ICoreEndurance
{
    Result AcceptDamage(Asteroid asteroid);
    Result AcceptDamage(Meteorite meteorite);
}