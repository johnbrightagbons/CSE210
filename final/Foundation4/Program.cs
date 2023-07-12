using System;

class Program
{
    static void Main()
    {
        Activity runningActivity = new Running(DateTime.Parse("03 July 2023"), 30, 3.0);
        Activity cyclingActivity = new Cycling(DateTime.Parse("03 July 2023"), 30, 6.0);
        Activity swimmingActivity = new Swimming(DateTime.Parse("03 July 2023"), 30, 50);

        Activity[] activities = { runningActivity, cyclingActivity, swimmingActivity };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
