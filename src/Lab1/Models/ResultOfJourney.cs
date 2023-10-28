namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class ResultOfJourney
{
    public ResultOfJourney(ShipCondition shipCondition, int daysForJourney, int usedFuel)
    {
        ShipCondition = shipCondition;
        DaysForJourney = daysForJourney;
        UsedFuel = usedFuel;
    }

    public ShipCondition ShipCondition { get; }
    public int DaysForJourney { get; }
    public int UsedFuel { get; }

    public override string ToString()
    {
        return ShipCondition.ToString() + "/Days " + DaysForJourney + "/Fuel " + UsedFuel;
    }
}