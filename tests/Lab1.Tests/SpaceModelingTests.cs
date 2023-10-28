using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Models.RouteLen;
using Itmo.ObjectOrientedProgramming.Lab1.Service;
using Itmo.ObjectOrientedProgramming.Lab1.Tools;
using Itmo.ObjectOrientedProgramming.Lab1.Tools.SpaceBuilders;
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

    public static IEnumerable<object[]> DataForFirstTest()
    {
        yield return new object[] { new Avgur(80) };
        yield return new object[] { new TourShuttle(80) };
    }

    public static IEnumerable<object[]> DataForSecondTest()
    {
        yield return new object[] { new Valkas(80) };
        yield return new object[] { new ValkasWithPhotonDeflector(80) };
    }

    public static IEnumerable<object[]> DataForThirdTest()
    {
        yield return new object[] { new Valkas(80) };
        yield return new object[] { new Avgur(80) };
        yield return new object[] { new Meridian(80) };
    }

    public static IEnumerable<object[]> DataForFourthTest()
    {
        yield return new object[] { new Valkas(80) };
        yield return new object[] { new TourShuttle(80) };
    }

    public static IEnumerable<object[]> DataForFifthTest()
    {
        yield return new object[] { new Avgur(80) };
        yield return new object[] { new Stella(80) };
    }

    public static IEnumerable<object[]> DataForSixthTest()
    {
        yield return new object[] { new Valkas(80) };
        yield return new object[] { new TourShuttle(80) };
    }

    public static IEnumerable<object[]> DataForSeventhTest()
    {
        yield return new object[] { new Avgur(160) };
        yield return new object[] { new TourShuttle(160) };
        yield return new object[] { new Valkas(160) };
        yield return new object[] { new Stella(160) };
        yield return new object[] { new Meridian(160) };
    }

    [Theory]
    [MemberData(nameof(DataForFirstTest))]
    public void MediumLengthHighDensityNebula(Ship ship)
    {
        ArgumentNullException.ThrowIfNull(ship);
        Route route = new RouteBuilder().AddRoute(
                new RoutePart(new HighDensityNebulaBuilder().Build(), new MediumLen())).Build();
        JourneyService service = new JourneyServiceBuilder().AddShip(ship).SetRoute(route)
            .SetDamageCalcTool(new DamageCalcTool()).SetFuelCalcTool(new FuelCountTool()).Build();
        IEnumerable<ResultOfJourney> res = service.InitiateJourney();
        PrintResults(res);
    }

    [Theory]
    [MemberData(nameof(DataForSecondTest))]
    public void AntimatterInHighDensityNebula(Ship ship)
    {
        ArgumentNullException.ThrowIfNull(ship);
        Route route = new RouteBuilder().AddRoute(
                new RoutePart(
                    new HighDensityNebulaBuilder()
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
    [MemberData(nameof(DataForThirdTest))]
    public void WhaleInNeutronParticlesNebula(Ship ship)
    {
        ArgumentNullException.ThrowIfNull(ship);
        Route route = new RouteBuilder().AddRoute(
                new RoutePart(
                    new NeutronParticlesNebulaBuilder()
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
    [MemberData(nameof(DataForFourthTest))]
    public void SmallLengthDefaultSpace(Ship ship)
    {
        ArgumentNullException.ThrowIfNull(ship);
        Route route = new RouteBuilder().AddRoute(
                new RoutePart(
                    new DefaultSpaceBuilder().Build(),
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
    [MemberData(nameof(DataForFifthTest))]
    public void StellaAndAvgurInHighDensityNebula(Ship ship)
    {
        ArgumentNullException.ThrowIfNull(ship);
        Route route = new RouteBuilder().AddRoute(
                new RoutePart(
                    new HighDensityNebulaBuilder().Build(),
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
    [MemberData(nameof(DataForSixthTest))]
    public void TourShuttleAndValkasInNeutronParticlesNebula(Ship ship)
    {
        ArgumentNullException.ThrowIfNull(ship);
        Route route = new RouteBuilder().AddRoute(
                new RoutePart(
                    new NeutronParticlesNebulaBuilder().Build(),
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
    [MemberData(nameof(DataForSeventhTest))]
    public void RoutePartsWIthAndNoObsticles(Ship ship)
    {
        ArgumentNullException.ThrowIfNull(ship);
        Route route = new RouteBuilder()
            .AddRoute(
                new RoutePart(
                    new DefaultSpaceBuilder()
                        .AddObstacle(new Meteorite())
                        .AddObstacle(new Meteorite())
                        .AddObstacle(new Asteroid())
                        .Build(),
                    new MediumLen()))
            .AddRoute(
                new RoutePart(
                    new DefaultSpaceBuilder()
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