using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

public interface ISpaceType
{
    IReadOnlyCollection<Obstacles> Obstacles { get; }
}