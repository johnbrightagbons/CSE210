using System;


class MindFulnessGame
{
    waitDisplay display = new waitDisplay();
    public MindFulnessGame()
    {

        Activity newA = new Activity("Start Activity");
        SetActivity(newA.DisplayMenu());
    }

    public void SetActivity(int choice)
    {
        if (choice == 1)
        {
            BreathingActivity breath = new BreathingActivity("Breathing");
            int numberSecondsToRun = breath.DisplayWelcomeMessage();
            breath.DisplayGetReady();
            display.displaySpinner(3);
            display.displayCountDown(4, numberSecondsToRun, breath.getActivityList());
            breath.FinishActivity(numberSecondsToRun, breath.getActivityName());
            display.displaySpinner(5);
            SetActivity(breath.DisplayMenu());
        }
        else if (choice == 2)
        {
            ReflectionActivity reflect = new ReflectionActivity("Reflection");
            int numberSecondsToRun = reflect.DisplayWelcomeMessage();
            reflect.setNumberOfSecondsToThink(numberSecondsToRun);
            reflect.DisplayGetReady();
            display.displaySpinner(3);
            reflect.getRandomReflectionActivity();
            display.displayCountDown(4, numberSecondsToRun, null, "Starting in ");
            display.displaySpinnerWithText(reflect.getRandomReflectionQuestionActivity(), reflect.getNumberOfSecondsToThink());
            reflect.FinishActivity(numberSecondsToRun, reflect.getActivityName());
            display.displaySpinner(5);
            SetActivity(reflect.DisplayMenu());
        }
        else if (choice == 3)
        {
            ListingActivity listing = new ListingActivity("Listing");
            int numberSecondsToRun = listing.DisplayWelcomeMessage();
            listing.DisplayGetReady();
            display.displaySpinner(3);
            listing.DisplayActivity();
            display.displayCountDown(4, numberSecondsToRun, null, "Starting in ");
            listing.setListingList(display.GetMultipleLinesWithTimer(numberSecondsToRun));
            listing.displayTotalListingCount();
            listing.FinishActivity(numberSecondsToRun, listing.getActivityName());
            display.displaySpinner(5);
            SetActivity(listing.DisplayMenu());

        }
        else
        {
            Environment.Exit(0);
        }
    }

    public void setActivityTime(int seconds)
    {

    }
}