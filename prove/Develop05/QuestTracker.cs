using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    class QuestTracker
    {
        private List<Goal> goals;
        private int score;

        public int Score { get { return score; } }

        public QuestTracker()
        {
            goals = new List<Goal>();
            score = 0;
        }

        public void AddGoal(Goal goal)
        {
            goals.Add(goal);
        }

        public void RecordEvent(string goalName)
        {
            Goal goal = goals.Find(g => g.Name == goalName);
            if (goal != null)
            {
                goal.RecordEvent();
                score += goal.GetValue();
            }
        }

        public void DisplayScore()
        {
            Console.WriteLine("Your Current Point(s): " + score);
        }

        public void DisplayGoals()
        {
            foreach (Goal goal in goals)
            {
                Console.Write($"[{(goal.IsCompleted ? "X" : " ")}] {goal.Name} ");
                if (goal is ChecklistGoal checklistGoal)
                    Console.WriteLine($"Completed {checklistGoal.TimesCompleted}/{checklistGoal.TargetTimes} times");
                else
                    Console.WriteLine();
            }
        }

        public void SaveToFile(string fileName)
        {
            Console.Write("Enter the file name to save the goals: ");
            string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Goal goal in goals)
                {
                    writer.WriteLine(goal.Name + "|" + goal.Description + "|" + goal.IsCompleted);
                }
            }

            Console.WriteLine("Goals saved to file.");
        }

        public static QuestTracker LoadFromFile(string fileName)
        {
            QuestTracker questTracker = new QuestTracker();

            Console.Write("Enter the file name to load the goals from: ");
            string filename = Console.ReadLine();

            if (!File.Exists(filename))
            {
                Console.WriteLine("File does not exist.");
                return questTracker;
            }

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        string goalName = parts[0];
                        string goalDescription = parts[1];
                        bool isCompleted = bool.Parse(parts[2]);

                        // Determine the goal type based on the number of parts
                        if (parts.Length == 3)
                        {
                            questTracker.AddGoal(new SimpleGoal(goalName, goalDescription));
                        }
                        else if (parts.Length == 4)
                        {
                            int goalValue = int.Parse(parts[3]);
                            questTracker.AddGoal(new EternalGoal(goalName, goalDescription, goalValue));
                        }
                        else if (parts.Length == 6)
                        {
                            int targetTimes = int.Parse(parts[3]);
                            int perEventValue = int.Parse(parts[4]);
                            int bonusValue = int.Parse(parts[5]);
                            questTracker.AddGoal(new ChecklistGoal(goalName, goalDescription, targetTimes, perEventValue, bonusValue));
                        }
                    }
                }
            }

            Console.WriteLine("Goals loaded from file.");
            return questTracker;
        }

        internal static QuestTracker LoadFromFile(object filename)
        {
            throw new NotImplementedException();
        }

        internal void SaveToFile(string v, object fileName)
        {
            throw new NotImplementedException();
        }
    }
}
