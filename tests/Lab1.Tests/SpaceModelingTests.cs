﻿using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Models.RouteLen;
using Itmo.ObjectOrientedProgramming.Lab1.Service;
using Itmo.ObjectOrientedProgramming.Lab1.Tests.Data;
using Itmo.ObjectOrientedProgramming.Lab1.Tools;
using Xunit;
using Xunit.Abstractions;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class SpaceModelingTests
{
    private readonly ITestOutputHelper _outputHelper;

    public SpaceModelingTests(ITestOutputHelper testOutputHelper)
    {
        _outputHelper = testOutputHelper;
    }

    [Theory]
    [ClassData(typeof(FirstTestData))]
    public void Test1(Ship ship)
    {
        ArgumentNullException.ThrowIfNull(ship);
        Route route = new RouteBuilder().AddRoute(
                new RoutePart(new SpaceBuilder().SetSpaceType(SpaceType.HighDensityNebula).Build(), new MediumLen()))
            .Build();
        JourneyService service = new JourneyServiceBuilder().AddShip(ship).SetRoute(route)
            .SetDamageCalcTool(new DamageCalcTool()).SetFuelCalcTool(new FuelCountTool()).Build();
        IEnumerable<ResultOfJourney> res = service.InitiateJourney();
        PrintResults(res);
    }

    [Theory]
    [ClassData(typeof(SecondTestData))]
    public void Test2(Ship ship)
    {
        ArgumentNullException.ThrowIfNull(ship);
        Route route = new RouteBuilder().AddRoute(
                new RoutePart(
                    new SpaceBuilder()
                        .SetSpaceType(SpaceType.HighDensityNebula)
                        .AddObstacle(new AntimatterFlash())
                        .Build(),
                    new SmallLen()))
            .Build();
        JourneyService service = new JourneyServiceBuilder().AddShip(ship).SetRoute(route)
            .SetDamageCalcTool(new DamageCalcTool()).SetFuelCalcTool(new FuelCountTool()).Build();
        IEnumerable<ResultOfJourney> res = service.InitiateJourney();
        PrintResults(res);
    }

    [Theory]
    [ClassData(typeof(ThirdTestData))]
    public void Test3(Ship ship)
    {
        ArgumentNullException.ThrowIfNull(ship);
        Route route = new RouteBuilder().AddRoute(
                new RoutePart(
                    new SpaceBuilder()
                        .SetSpaceType(SpaceType.NeutronParticlesNebula)
                        .AddObstacle(new SpaceWhale())
                        .Build(),
                    new SmallLen()))
            .Build();
        JourneyService service = new JourneyServiceBuilder().AddShip(ship).SetRoute(route)
            .SetDamageCalcTool(new DamageCalcTool()).SetFuelCalcTool(new FuelCountTool()).Build();
        IEnumerable<ResultOfJourney> res = service.InitiateJourney();
        PrintResults(res);
    }

    [Theory]
    [ClassData(typeof(FourthTestData))]
    public void Test4(Ship ship)
    {
        ArgumentNullException.ThrowIfNull(ship);
        Route route = new RouteBuilder().AddRoute(
                new RoutePart(
                    new SpaceBuilder()
                        .SetSpaceType(SpaceType.DefaultSpace)
                        .Build(),
                    new SmallLen()))
            .Build();
        JourneyService service = new JourneyServiceBuilder().AddShip(ship).SetRoute(route)
            .SetDamageCalcTool(new DamageCalcTool()).SetFuelCalcTool(new FuelCountTool()).Build();
        IEnumerable<ResultOfJourney> res = service.InitiateJourney();
        foreach (ResultOfJourney r in res)
        {
            _outputHelper.WriteLine(r.ToString());
        }
    }

    [Theory]
    [ClassData(typeof(FifthTestData))]
    public void Test5(Ship ship)
    {
        ArgumentNullException.ThrowIfNull(ship);
        Route route = new RouteBuilder().AddRoute(
                new RoutePart(
                    new SpaceBuilder()
                        .SetSpaceType(SpaceType.HighDensityNebula)
                        .Build(),
                    new MediumLen()))
            .Build();
        JourneyService service = new JourneyServiceBuilder().AddShip(ship).SetRoute(route)
            .SetDamageCalcTool(new DamageCalcTool()).SetFuelCalcTool(new FuelCountTool()).Build();
        IEnumerable<ResultOfJourney> res = service.InitiateJourney();
        foreach (ResultOfJourney r in res)
        {
            _outputHelper.WriteLine(r.ToString());
        }
    }

    [Theory]
    [ClassData(typeof(SixthTestData))]
    public void Test6(Ship ship)
    {
        ArgumentNullException.ThrowIfNull(ship);
        Route route = new RouteBuilder().AddRoute(
                new RoutePart(
                    new SpaceBuilder()
                        .SetSpaceType(SpaceType.NeutronParticlesNebula)
                        .Build(),
                    new SmallLen()))
            .Build();
        JourneyService service = new JourneyServiceBuilder().AddShip(ship).SetRoute(route)
            .SetDamageCalcTool(new DamageCalcTool()).SetFuelCalcTool(new FuelCountTool()).Build();
        IEnumerable<ResultOfJourney> res = service.InitiateJourney();
        foreach (ResultOfJourney r in res)
        {
            _outputHelper.WriteLine(r.ToString());
        }
    }

    [Theory]
    [ClassData(typeof(SeventhTestData))]
    public void Test7(Ship ship)
    {
        ArgumentNullException.ThrowIfNull(ship);
        Route route = new RouteBuilder()
            .AddRoute(
                new RoutePart(
                    new SpaceBuilder()
                        .SetSpaceType(SpaceType.DefaultSpace)
                        .AddObstacle(new Meteorite())
                        .AddObstacle(new Meteorite())
                        .AddObstacle(new Asteroid())
                        .Build(),
                    new MediumLen()))
            .AddRoute(
                new RoutePart(
                    new SpaceBuilder()
                        .SetSpaceType(SpaceType.DefaultSpace)
                        .AddObstacle(new Meteorite())
                        .AddObstacle(new Meteorite())
                        .Build(),
                    new SmallLen()))
            .Build();
        JourneyService service = new JourneyServiceBuilder().AddShip(ship).SetRoute(route)
            .SetDamageCalcTool(new DamageCalcTool()).SetFuelCalcTool(new FuelCountTool()).Build();
        IEnumerable<ResultOfJourney> res = service.InitiateJourney();
        foreach (ResultOfJourney r in res)
        {
            _outputHelper.WriteLine(r.ToString());
        }
    }

    private void PrintResults(IEnumerable<ResultOfJourney> res)
    {
        foreach (ResultOfJourney r in res)
        {
            _outputHelper.WriteLine(r.ToString());
        }
    }
}