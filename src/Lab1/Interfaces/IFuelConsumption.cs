namespace Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

public interface IFuelConsumption
{
    int GetCoefficient(int fuel);
}

/*
 * Линейная - столько же топлива, сколько соотношение размера к дистанции
 * Логарифмическая - линейная умноженная на Log
 * Квадратичная - линейная в квадрате
 */