using System;


class Activity
{

    private string nameOfActivity = string.Empty;
    private List<string> activityMenu;
    private string description = string.Empty;

    public Activity (string _nameOfActivity)
    {
        activityMenu = nameOfActivity;
    }

    public void SetDescription(string _description)
    {
        description = _description;
    }

    public void SetActivityMenu(List<string> _activityMenu)
    {
        activityMenu = _activityMenu.ToList();
    }
    public int DisplayMenu()
    {
        clearConsole();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("   1.- Start the breathing activity");
        Console.WriteLine("   2.- Start the reflection activity");
        Console.WriteLine("   3.- Start the listing activity");
        Console.WriteLine("   4.- Quit");
        Console.WriteLine("Kindly make a choice from the menu: ");
        int menuChoice = int.Parse(Console.ReadLine());

        return menuChoice;
    }

    public int DisplayWelcomeMessage()
    {
        clearConsole();
        Console.WriteLine($"Welcome to the {char.ToUpper(nameOfActivity[0])}{nameOfActivity.Substring(1)} Activity");
        Console.WriteLine($"{description}");
        Console.WriteLine("How long in seconds will you like for a session? ");
        int timeChoice = int.Parse(Console.ReadLine());
        return timeChoice;
    }

    public void DisplayGetReady()
    {
        clearConsole();
        Console.WriteLine("Get Ready...");
    }

    public void clearConsole()
    {
        Console.Clear();
    }

    public void FinishActivity(int timeToRun, string _nameOfActivity)
    {
        Console.WriteLine("Good Job You");
        Console.WriteLine($"Ÿou have completed another {timeToRun} seconds of the {_nameOfActivity} Activity");
    }

    public string getActivityName()
    {
        return nameOfActivity;
    }
}