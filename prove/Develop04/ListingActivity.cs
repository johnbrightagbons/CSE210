class ListingActivity : Activity
{
    public ListingActivity(string nameOfActivity) : base(nameOfActivity)
    {
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        SetActivityMenu(new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        });
    }

    public void DisplayActivity()
    {
        Random random = new Random();
        int index = random.Next(activityMenu.Count);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"---- {activityMenu[index]} ----");
    }
}
