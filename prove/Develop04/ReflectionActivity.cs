class ReflectionActivity : Activity
{
    private int thinkingSeconds;
    private List<string> questionList;

    public ReflectionActivity(string nameOfActivity) : base(nameOfActivity)
    {
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        SetActivityMenu(new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        });
        questionList = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?"
        };
    }

    public void SetNumberOfSecondsToThink(int timeToRun)
    {
        thinkingSeconds = timeToRun / 5;
    }

    public int GetNumberOfSecondsToThink()
    {
        return thinkingSeconds;
    }

    public List<string> GetQuestionList()
    {
        return questionList;
    }

    public void GetRandomReflectionActivity()
    {
        Random random = new Random();
        int index = random.Next(activityMenu.Count);
        Console.WriteLine("Consider the following prompt:");
        Thread.Sleep(200);
        Console.WriteLine($"--- {activityMenu[index]} ---");
        Thread.Sleep(500);
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
        Thread.Sleep(200);
    }

    public List<string> GetRandomReflectionQuestionActivity()
    {
        int numberOfIndexes = thinkingSeconds;
        Random random = new Random();
        List<string> list = new List<string>();
        while (list.Count < numberOfIndexes)
        {
            int index = random.Next(questionList.Count);
            if (!list.Contains(questionList[index]))
            {
                list.Add(questionList[index]);
            }
        }
        return list;
    }
}
