class MindfulnessGame
{
    private BreathingActivity breathingActivity;
    private ReflectionActivity reflectionActivity;
    private ListingActivity listingActivity;

    public MindfulnessGame()
    {
        breathingActivity = new BreathingActivity("Breathing");
        reflectionActivity = new ReflectionActivity("Reflection");
        listingActivity = new ListingActivity("Listing");
    }

    public void StartGame()
    {
        bool quit = false;

        while (!quit)
        {
            int menuChoice = DisplayMainMenu();

            switch (menuChoice)
            {
                case 1:
                    StartActivity(breathingActivity);
                    break;
                case 2:
                    StartActivity(reflectionActivity);
                    break;
                case 3:
                    listingActivity.DisplayActivity();
                    break;
                case 4:
                    quit = true;
                    Console.WriteLine("Thank you for playing! Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid menu choice. Please try again.");
                    break;
            }
        }
    }

    public int DisplayMainMenu()
    {
        Console.Clear();
        Console.WriteLine("Mindfulness Activities");
        Console.WriteLine("----------------------");
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("   1. Breathing Activity");
        Console.WriteLine("   2. Reflection Activity");
        Console.WriteLine("   3. Listing Activity");
        Console.WriteLine("   4. Quit");
        Console.WriteLine("Please choose an option from the menu: ");
        int menuChoice = int.Parse(Console.ReadLine());
        return menuChoice;
    }

    public void StartActivity(Activity activity)
    {
        int timeChoice = activity.DisplayWelcomeMessage();
        activity.DisplayGetReady();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timeChoice);

        while (DateTime.Now < endTime)
        {
            foreach (string menuOption in activity.activityMenu)
            {
                Console.WriteLine(menuOption);
                Thread.Sleep(1000);
            }
        }

        activity.FinishActivity(timeChoice);
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
