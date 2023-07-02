using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Activity
{
    private string _nameOfActivity;
    public List<string> activityMenu;
    private string _description;

    public Activity(string nameOfActivity)
    {
        _nameOfActivity = nameOfActivity;
        activityMenu = new List<string>();
        _description = string.Empty;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetActivityMenu(List<string> menu)
    {
        activityMenu = menu.ToList();
    }

    public int DisplayMenu()
    {
        ClearConsole();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("   1. Start the breathing activity");
        Console.WriteLine("   2. Start the reflection activity");
        Console.WriteLine("   3. Start the listing activity");
        Console.WriteLine("   4. Quit");
        Console.WriteLine("Please choose an option from the menu: ");
        int menuChoice = int.Parse(Console.ReadLine());

        return menuChoice;
    }

    public int DisplayWelcomeMessage()
    {
        ClearConsole();
        Console.WriteLine($"Welcome to the {char.ToUpper(_nameOfActivity[0])}{_nameOfActivity.Substring(1)} Activity");
        Console.WriteLine($"{_description}");
        Console.WriteLine("How long in seconds would you like for a session? ");
        int timeChoice = int.Parse(Console.ReadLine());
        return timeChoice;
    }

    public void DisplayGetReady()
    {
        ClearConsole();
        Console.WriteLine("Get Ready...");
    }

    public void ClearConsole()
    {
        Console.Clear();
    }

    public void FinishActivity(int timeToRun)
    {
        Console.WriteLine("Good Job!");
        Console.WriteLine($"You have completed another {timeToRun} seconds of the {_nameOfActivity} Activity");
    }

    public string GetActivityName()
    {
        return _nameOfActivity;
    }

    public List<string> GetActivityMenu()
    {
        return activityMenu;
    }
}
