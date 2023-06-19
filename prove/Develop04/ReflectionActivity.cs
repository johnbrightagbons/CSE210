class ReflectionActivity : Activity
{
    private int thinkingSeconds;
    private List<string> questionList;

    public ReflectionActivity(string nameOfActivity) : base(nameOfActivity)
    {
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        SetActivityMenu(new List<string>
        {
            "Think about a time when you felt proud of yourself for accomplishing something difficult.",
            "Think about a time when you faced a challenge and overcame it.",
            "Think about a time when you helped someone else and made a positive impact."
        });

        thinkingSeconds = 10;
        questionList = new List<string>(activityMenu);
    }

    public void DisplayActivity()
    {
        ClearConsole();
        Console.WriteLine("Take a moment to reflect on the following prompts:");
        Console.WriteLine();

        foreach (string question in questionList)
        {
            Console.WriteLine($"--- {question} ---");
            Console.WriteLine();
            Thread.Sleep(thinkingSeconds * 1000);
            Console.WriteLine("Time's up!");
            Console.WriteLine();
        }

        Console.WriteLine("You have completed the reflection activity.");
    }
}
