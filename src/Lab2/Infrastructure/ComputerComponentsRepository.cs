using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Infrastructure;

public static class ComputerComponentsRepository
{
    private static readonly List<Motherboard> _motherboards = new();
    private static readonly List<Cpu> _cpus = new();
    private static readonly List<CpuCoolingSystem> _coolingSystems = new();
    private static readonly List<Gpu> _gpus = new();
    private static readonly List<ComputerCase> _computerCases = new();
    private static readonly List<PowerSupply> _powerSupplies = new();
    private static readonly List<WiFiAdapter> _wifiAdapters = new();
    private static readonly List<SsdDrive> _ssdDrives = new();
    private static readonly List<HardDisk> _hardDisks = new();
    private static readonly List<Ram> _rams = new();

    public static IReadOnlyList<Motherboard> Motherboards => _motherboards;
    public static IReadOnlyList<Cpu> Cpus => _cpus;
    public static IReadOnlyList<CpuCoolingSystem> CoolingSystems => _coolingSystems;
    public static IReadOnlyList<Gpu> Gpus => _gpus;
    public static IReadOnlyList<ComputerCase> ComputerCases => _computerCases;
    public static IReadOnlyList<PowerSupply> PowerSupplies => _powerSupplies;
    public static IReadOnlyList<WiFiAdapter> WiFiAdapters => _wifiAdapters;
    public static IReadOnlyList<SsdDrive> SsdDrives => _ssdDrives;
    public static IReadOnlyList<HardDisk> HardDisks => _hardDisks;
    public static IReadOnlyList<Ram> Rams => _rams;

    public static void AddMotherboard(Motherboard motherboard)
    {
        ArgumentNullException.ThrowIfNull(motherboard, nameof(motherboard));

        if (!_motherboards.Contains(motherboard))
            _motherboards.Add(motherboard);
    }

    public static void AddCpu(Cpu cpu)
    {
        ArgumentNullException.ThrowIfNull(cpu, nameof(cpu));

        if (!_cpus.Contains(cpu))
            _cpus.Add(cpu);
    }

    public static void AddCoolingSystem(CpuCoolingSystem coolingSystem)
    {
        ArgumentNullException.ThrowIfNull(coolingSystem, nameof(coolingSystem));

        if (!_coolingSystems.Contains(coolingSystem))
            _coolingSystems.Add(coolingSystem);
    }

    public static void AddGpu(Gpu gpu)
    {
        ArgumentNullException.ThrowIfNull(gpu, nameof(gpu));

        if (!_gpus.Contains(gpu))
            _gpus.Add(gpu);
    }

    public static void AddComputerCase(ComputerCase computerCase)
    {
        ArgumentNullException.ThrowIfNull(computerCase, nameof(computerCase));

        if (!_computerCases.Contains(computerCase))
            _computerCases.Add(computerCase);
    }

    public static void AddPowerSupply(PowerSupply powerSupply)
    {
        ArgumentNullException.ThrowIfNull(powerSupply, nameof(powerSupply));

        if (!_powerSupplies.Contains(powerSupply))
            _powerSupplies.Add(powerSupply);
    }

    public static void AddWiFiAdapter(WiFiAdapter wifiAdapter)
    {
        ArgumentNullException.ThrowIfNull(wifiAdapter, nameof(wifiAdapter));

        if (!_wifiAdapters.Contains(wifiAdapter))
            _wifiAdapters.Add(wifiAdapter);
    }

    public static void AddSsdDrive(SsdDrive ssd)
    {
        ArgumentNullException.ThrowIfNull(ssd, nameof(ssd));

        if (!_ssdDrives.Contains(ssd))
            _ssdDrives.Add(ssd);
    }

    public static void AddHardDisk(HardDisk hardDisk)
    {
        ArgumentNullException.ThrowIfNull(hardDisk, nameof(hardDisk));

        if (!_hardDisks.Contains(hardDisk))
            _hardDisks.Add(hardDisk);
    }

    public static void AddRam(Ram ram)
    {
        ArgumentNullException.ThrowIfNull(ram, nameof(ram));

        if (!_rams.Contains(ram))
            _rams.Add(ram);
    }
}
