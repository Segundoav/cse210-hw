using System;
using System.Collections.Generic;

public class Program

{
    public static void Main(string[] args)
    {
        
        List<Activity> activities = new List<Activity>();

        
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2022, 11, 3), 45, 15.0));
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 30, 20));

        
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

// Activity
public class Activity
{
    private DateTime date;
    protected int duration; 

    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    
    public virtual double GetDistance() { return 0; }
    public virtual double GetSpeed() { return 0; }
    public virtual double GetPace() { return 0; }

    
    public string GetSummary()
    {
        return $"{date:dd MMM yyyy} {GetType().Name} ({duration} min): " +
               $"Distancia {GetDistance():F1}, Velocidad {GetSpeed():F1}, Ritmo: {GetPace():F1}";
    }
}

// Running 
public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;
    public override double GetSpeed() => (distance / duration) * 60; 
    public override double GetPace() => (duration / distance);
}

// Cycling 
public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        this.speed = speed;
    }

    public override double GetDistance() => (speed * duration) / 60; 
    public override double GetSpeed() => speed; 
    public override double GetPace() => 60 / speed; 
}

// Swimming 
public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance() => laps * 50 / 1000.0; 
    public override double GetSpeed() => (GetDistance() / duration) * 60; 
    public override double GetPace() => duration / GetDistance(); 
}