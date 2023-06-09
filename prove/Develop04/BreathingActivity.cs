using System;

class BreathingActivity : Activity
{
    List<string> activityMenu = new List<string> { "Breath in", "breath out" };
    string description = "This activity will help you relax by walking your \n through breathing in and out slowly. \n Clear your mind and focus on your breathing.";
    public BreathingActivity(string _nameOfActivity) : base(_nameOfActivity)
    {
        SetDescription(description);
        SetActivityList(activityMenu);
    }

    public List<string> getActivityList()
    {
        return activityMenu;
    }
}