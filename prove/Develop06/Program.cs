using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int totalPoints = 0;

        while (true)
        {
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Total Score");
            Console.WriteLine("5. Exit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateNewGoal(goals);
            }
            else if (choice == "2")
            {
                ListGoals(goals);
            }
            else if (choice == "3")
            {
                totalPoints += RecordEvent(goals);
                Console.WriteLine($"Total points: {totalPoints}");
            }
            else if (choice == "4")
            {
                Console.WriteLine($"Total Score: {totalPoints} points");
            }
            else if (choice == "5")
            {
                break;
            }
        }
    }

    static void CreateNewGoal(List<Goal> goals)
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string choice = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            goals.Add(new SimpleGoal(name, points));
        }
        else if (choice == "2")
        {
            goals.Add(new EternalGoal(name, points));
        }
        else if (choice == "3")
        {
            Console.Write("Enter the target count: ");
            int targetCount = int.Parse(Console.ReadLine());

            Console.Write("Enter the bonus points: ");
            int bonusPoints = int.Parse(Console.ReadLine());

            goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
        }
    }

    static void ListGoals(List<Goal> goals)
    {
        Console.WriteLine("\nYour Goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.DisplayGoal());
        }
    }

    static int RecordEvent(List<Goal> goals)
    {
        ListGoals(goals);
        Console.Write("Select a goal number to record: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            return goals[goalIndex].RecordEvent();
        }

        return 0;
    }
}
