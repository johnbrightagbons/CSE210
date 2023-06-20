using System;
using System.Collections.Generic;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a class called questTracker and set the
            // choice to -1
            QuestTracker questTracker = new QuestTracker();

             // Display initial score
            questTracker.DisplayScore();


            int choice = -1;

            // Loop till the user enter choice 6 which is 'quite'
            while (choice != 6)
            {
                DisplayMenu(); // A function to show the menu
                choice = GetMenuChoice(); // Get user's choice from the menu

                switch (choice)
                {
                    case 1:
                        CreateGoal(questTracker);
                        break;
                    case 2:
                        questTracker.DisplayGoals();
                        break;
                    case 3:
                        questTracker.SaveToFile("questtracker.txt");
                        Console.WriteLine("Quest tracker saved to 'questtracker.txt'.");
                        break;
                    case 4:
                        questTracker = QuestTracker.LoadFromFile("questtracker.txt");
                        Console.WriteLine("Quest tracker loaded from 'questtracker.txt'.");
                        break;
                    case 5:
                        RecordEvent(questTracker);
                        break;
                    case 6:
                        Console.WriteLine("Quitting the program...Thanks for setting goals");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        // The DisplayMenu function displays the available menu options to the user.
        static void DisplayMenu()
        {
            Console.WriteLine("------ Eternal Quest ------");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
        }

        // The GetMenuChoice function prompts the user to enter their menu choice 
        // and reads the input as a string, then convert to integer
        static int GetMenuChoice()
        {
            Console.Write("Enter your choice: ");
            return int.Parse(Console.ReadLine());
        }

        static void CreateGoal(QuestTracker questTracker)
        {
            Console.WriteLine("------ Create Goal ------");
            Console.WriteLine("Select the type of goal:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");

            int goalType = int.Parse(Console.ReadLine());
            Console.Write("Enter the goal name: ");
            string goalName = Console.ReadLine();
            Console.Write("Enter the goal description: ");
            string goalDescription = Console.ReadLine();

            switch (goalType)
            {
                case 1:
                    Console.Write("Enter the goal value: ");
                    int goalValue = int.Parse(Console.ReadLine());
                    questTracker.AddGoal(new SimpleGoal(goalName, goalDescription, goalValue));
                    break;
                case 2:
                    Console.Write("Enter the goal value: ");
                    int eternalGoalValue = int.Parse(Console.ReadLine());
                    questTracker.AddGoal(new EternalGoal(goalName, goalDescription, eternalGoalValue));
                    break;
                case 3:
                    Console.Write("Enter the target times: ");
                    int targetTimes = int.Parse(Console.ReadLine());
                    Console.Write("Enter the per-event value: ");
                    int perEventValue = int.Parse(Console.ReadLine());
                    Console.Write("Enter the bonus value: ");
                    int bonusValue = int.Parse(Console.ReadLine());
                    questTracker.AddGoal(new ChecklistGoal(goalName, goalDescription, targetTimes, perEventValue, bonusValue));
                    break;
                default:
                    Console.WriteLine("Invalid goal type. Goal creation canceled.");
                    break;
            }

            Console.WriteLine("Goal created successfully.");
        }

        static void RecordEvent(QuestTracker questTracker)
        {
            Console.WriteLine("------ Record Event ------");
            Console.Write("Enter the goal name: ");
            string goalName = Console.ReadLine();
            questTracker.RecordEvent(goalName);
            Console.WriteLine("Event recorded successfully.");
        }
    }
}
