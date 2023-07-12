using System;

public class Running : Activity
{
    private double distance;  // Distance covered during the run

    public Running(DateTime date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (lengthInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return lengthInMinutes / distance;
    }

    public override string GetSummary()
    {
        return $"{date: dd MM yyyy} Running ({lengthInMinutes} min) - Distance: {distance:F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min/mile";
    }
}
