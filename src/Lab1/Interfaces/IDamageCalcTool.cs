using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

public interface IDamageCalcTool
{
    ShipCondition CalcDamage(Ship ship, ISpaceType space);
}