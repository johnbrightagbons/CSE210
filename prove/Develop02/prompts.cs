using System;
using System.Collections.Generic;

class Prompt
{
    public List<string> PromptsList { get; set; }

    public Prompt()
    {
        PromptsList = new List<string>();
        InitializePrompts();
    }

    private void InitializePrompts()
    {
        PromptsList.Add("Who was the most interesting person I interacted with today?");
        PromptsList.Add("What was the best part of my day?");
        PromptsList.Add("How did I see the hand of the Lord in my life today?");
        PromptsList.Add("What was the strongest emotion I felt today?");
        PromptsList.Add("If I had one thing I could do over today, what would it be?");
    }

    public string DisplayRandomQuestion()
    {
        Random random = new Random();
        int randIndex = random.Next(PromptsList.Count);
        return PromptsList[randIndex];
    }
}
