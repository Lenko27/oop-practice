namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public enum FuelConsumption
{
    Linear,
    Log,
    Square,
}

/*
 * Линейная - столько же топлива, сколько соотношение размера к дистанции
 * Логарифмическая - линейная умноженная на Log
 * Квадратичная - линейная в квадрате
 */