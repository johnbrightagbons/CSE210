class MindfulnessGame
{
    private WaitDisplay display;

    public MindfulnessGame()
    {
        display = new WaitDisplay();
        StartGame();
    }

    public void StartGame()
    {
        int choice = DisplayMainMenu();
        while (choice != 4)
        {
            switch (choice)
            {
                case 1:
                    BreathingActivity breath = new BreathingActivity("Breathing");
                    int breathTimeToRun = breath.DisplayWelcomeMessage();
                    breath.DisplayGetReady();
                    display.DisplaySpinner(3);
                    display.DisplayCountDown(4, breathTimeToRun, breath.GetActivityMenu());
                    breath.FinishActivity(breathTimeToRun);
                    display.DisplaySpinner(5);
                    break;
                case 2:
                    ReflectionActivity reflect = new ReflectionActivity("Reflection");
                    int reflectTimeToRun = reflect.DisplayWelcomeMessage();
                    reflect.SetNumberOfSecondsToThink(reflectTimeToRun);
                    reflect.DisplayGetReady();
                    display.DisplaySpinner(3);
                    reflect.GetRandomReflectionActivity();
                    display.DisplayCountDown(4, reflectTimeToRun);
                    display.DisplaySpinnerWithText(reflect.GetRandomReflectionQuestionActivity(), reflect.GetNumberOfSecondsToThink());
                    reflect.FinishActivity(reflectTimeToRun);
                    display.DisplaySpinner(5);
                    break;
                case 3:
                    ListingActivity listing = new ListingActivity("Listing");
                    int listingTimeToRun = listing.DisplayWelcomeMessage();
                    listing.DisplayGetReady();
                    display.DisplaySpinner(3);
                    listing.DisplayActivity();
                    display.DisplayCountDown(4, listingTimeToRun);
                    display.DisplaySpinnerWithText(display.GetMultipleLinesWithTimer(listingTimeToRun), listingTimeToRun);
                    listing.FinishActivity(listingTimeToRun);
                    display.DisplaySpinner(5);
                    break;
            }
            choice = DisplayMainMenu();
        }
        Environment.Exit(0);
    }

    public int DisplayMainMenu()
    {
        display.ClearConsole();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("   1. Start the breathing activity");
        Console.WriteLine("   2. Start the reflection activity");
        Console.WriteLine("   3. Start the listing activity");
        Console.WriteLine("   4. Quit");
        Console.WriteLine("Please choose an option from the menu: ");
        int menuChoice = int.Parse(Console.ReadLine());
        return menuChoice;
    }
}
