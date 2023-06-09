using System;


class MindFulnessGame
{
    WaitDisplay display = new WaitDisplay();
    public MindFulness()
    {

        Activity newA = new Activity("Start Activity");
        SetActivity(newA.DisplayMenu());
    }

    public void SetActivity(int choice)
    {
        if (choice == 1)
        {
            BreathingActivity breath = new BreathingActivity("Breathing");
            int timeToRun = breath.DisplayWelcomeMessage();
            breath.DisplayGetReady();
            display.displaySpinner(3);
            display.displayCountDown(4, timeToRun, breath.getActivityList());
            breath.FinishActivity(timeToRun, breath.getActivityName());
            display.displaySpinner(5);
            SetActivity(breath.DisplayMenu());
        }
        else if (choice == 2)
        {
            ReflectionActivity reflect = new ReflectionActivity("Reflection");
            int numSecondsToRun = reflect.DisplayWelcomeMessage();
            reflect.setNumberOfSecondsToThink(timeToRun);
            reflect.DisplayGetReady();
            display.displaySpinner(3);
            reflect.getRandomReflectionActivity();
            display.displayCountDown(4, timeToRun, null, "You can start in ");
            display.displaySpinnerWithText(reflect.getRandomReflectionQuestionActivity(), reflect.getNumberOfSecondsToThink());
            reflect.FinishActivity(timeToRun, reflect.getActivityName());
            display.displaySpinner(5);
            SetActivity(reflect.DisplayMenu());
        }
        else if (choice == 3)
        {
            ListingActivity listing = new ListingActivity("Listing");
            int timeToRun = listing.DisplayWelcomeMessage();
            listing.DisplayGetReady();
            display.displaySpinner(3);
            listing.DisplayActivity();
            display.displayCountDown(4, timeToRun, null, "You can start in  ");
            listing.setListingList(display.GetMultipleLinesWithTimer(timeToRun));
            listing.displayTotalListingCount();
            listing.FinishActivity(timeToRun, listing.getActivityName());
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