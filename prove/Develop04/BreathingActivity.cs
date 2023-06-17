class BreathingActivity : Activity
{
    public BreathingActivity(string nameOfActivity) : base(nameOfActivity)
    {
        SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        SetActivityMenu(new List<string> { "Breath in", "Breath out" });
    }
}
