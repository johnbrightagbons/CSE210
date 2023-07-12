using System;

public abstract class Activity
{
    private DateTime date;           // Date for the activity
    private int lengthInMinutes;     // Length of the activity in minutes

    public Activity(DateTime date, int lengthInMinutes)
    {
        this.date = date;
        this.lengthInMinutes = lengthInMinutes;
    }

    public abstract double GetDistance();   // Abstract method to calculate the distance
    public abstract double GetSpeed();      // Abstract method to calculate the speed
    public abstract double GetPace();       // Abstract method to calculate the pace
    public abstract string GetSummary();    // Abstract method to get the summary
}
