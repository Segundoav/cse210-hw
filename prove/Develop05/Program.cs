using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflection =  new ReflectionActivity();
        ListingActivity listing = new ListingActivity();

        Console.WriteLine("Selected an activity: ");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                breathing.ExecuteActivity();
                break;
            case 2:
                reflection.ExecuteActivity();
                break;
            case 3:
                listing.ExecuteActivity();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
        Console.WriteLine("Thank you for using the mindfulness program!");

    }
}