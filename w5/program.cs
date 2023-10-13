using System;
using System.Collections.Generic;

namespace EternalQuest
{
    public class Goal
    {
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public int Value { get; set; }

        public Goal(string name, int value)
        {
            Name = name;
            IsComplete = false;
            Value = value;
        }
    }

    public class EternalGoal : Goal
    {
        public EternalGoal(string name, int value) : base(name, value)
        {
        }

        public void RecordEvent()
        {
            // Increment the goal's value.
            Value++;
        }
    }

    public class ChecklistGoal : Goal
    {
        public int TargetCount { get; set; }
        public int CurrentCount { get; set; }

        public ChecklistGoal(string name, int value, int targetCount) : base(name, value)
        {
            TargetCount = targetCount;
            CurrentCount = 0;
        }

        public void RecordEvent()
        {
            // Increment the goal's current count.
            CurrentCount++;

            // If the goal has been completed, increment the goal's value.
            if (CurrentCount == TargetCount)
            {
                Value++;
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a list of goals.
            List<Goal> goals = new List<Goal>();

            // Add a simple goal.
            goals.Add(new Goal("Run a marathon", 1000));

            // Add an eternal goal.
            goals.Add(new EternalGoal("Read the scriptures", 100));

            // Add a checklist goal.
            goals.Add(new ChecklistGoal("Attend the temple", 50, 10));

            // Display the user's score.
            int totalScore = 0;
            foreach (Goal goal in goals)
            {
                totalScore += goal.Value;
            }
            Console.WriteLine("Total score: {0}", totalScore);

            // Allow the user to create new goals.
            Console.WriteLine("Enter a new goal: ");
            string goalName = Console.ReadLine();
            int goalValue = int.Parse(Console.ReadLine());
            Goal newGoal = new Goal(goalName, goalValue);
            goals.Add(newGoal);

            // Allow the user to record an event.
            Console.WriteLine("Enter the name of the goal you want to record an event for: ");
            string goalNameToRecordEventFor = Console.ReadLine();
            Goal goalToRecordEventFor = goals.Find(goal => goal.Name == goalNameToRecordEventFor);
            goalToRecordEventFor.RecordEvent();

            // Show a list of the goals.
            Console.WriteLine("List of goals: ");
            foreach (Goal goal in goals)
            {
                Console.WriteLine("{0}: {1}", goal.Name, goal.IsComplete ? "Complete" : "Incomplete");
            }

            // Save and load the user's goals and score.
            // TODO: Implement this functionality.
        }
    }
}
