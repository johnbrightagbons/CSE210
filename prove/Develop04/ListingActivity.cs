using System;

class ListingActivity : Activity
{
    List<string> activityMenu = new List<string> 
    {"Who are people that you appreciate?"
                                                  ,"What are personal strengths of yours?"
                                                  ,"Who are people that you have helped this week?"
                                                  ,"When have you felt the Holy Ghost this month?"
                                                  ,"Who are some of your personal heroes?"};
    List<string> listingMenu = new List<string>();
    string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    public ListingActivity(string _nameOfActivity) : base(_nameOfActivity)
    {
        SetDescription(description);
        SetActivityMenu(activityMenu);
    }

    public void DisplayActivity()
    {

        Random random = new Random();
        int index = random.Next(activityMenu.Count);
        Console.WriteLine("List as many reponses you can to the following prompt");
        Console.WriteLine($"---- {activityMenu[index]} ----");
    }

    public void setListingMenu(List<string> ll)
    {
        listingMenu = ll;
    }

    public int getListingMenuCount()
    {
        return listingMenu.Count;
    }

    public void displayTotalListingCount()
    {
        Console.WriteLine($"You listed {getListingMenuCount()} items");
    }
}