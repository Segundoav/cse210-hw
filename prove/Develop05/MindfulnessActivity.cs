using System;
using System.Threading;

public class MindfulnessActivity
{
    protected int duration;
    public void SetDuration(int seconds)
    {
        duration = seconds;
    }

    public virtual void StartActivity(string activityName, string description)
    {
        Console.WriteLine($"Starting {activityName}...");
        Console.WriteLine(description);
        Console.WriteLine("Please enter the duration of the activity in seconds:");
        int seconds = int.Parse(Console.ReadLine());
        SetDuration(seconds);
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(3000);
    }

    public virtual void EndActivity(string activityName)

    {
        Console.WriteLine($"Well done! You have completed the {activityName},");
        Console.WriteLine($"You spent {duration} seconds on this activity.");
        Thread.Sleep(3000);

    }

    public virtual void ExecuteActivity()

    {
        Console.WriteLine("Executing a generic mindfulness activity...");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

}
