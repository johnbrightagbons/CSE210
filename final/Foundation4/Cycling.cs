using System;

public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return speed * (lengthInMinutes / 60.0);
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60.0 / speed;
    }

    public override string GetSummary()
    {
        return $"{date: dd MM yyyy} Cycling ({lengthInMinutes} min) - Distance: {GetDistance():F1} miles, Speed: {speed:F1} mph, Pace: {GetPace():F1} min/mile";
    }
}
