﻿using System.Collections;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests.Data;

public class ThirdTestData : IEnumerable<object[]>
{
    private const int FuelCount = 80;

    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { new Valkas(FuelCount) };
        yield return new object[] { new Avgur(FuelCount) };
        yield return new object[] { new Meridian(FuelCount) };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}