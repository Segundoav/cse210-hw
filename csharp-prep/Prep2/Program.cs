using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for the percentage of their rating

        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();

        int percent = int.Parse(answer);

        string letter = "";


        // Assign a letter grade

        if (percent >= 90)

        {
            letter = "A";
        }


        else if (percent >= 80)

        {
            letter = "B";
        }

        else if (percent >= 70)

        {
            letter = "C";
        }

        else if (percent >= 60)

        {
            letter = "D";
        }


        else

        {
            letter = "F";
        }

        // Show letter grade


        Console.WriteLine($"Your grade is: {letter}");


        if (percent >= 70)

        {
            Console.WriteLine("You passed!");
        }

        else

        {
            Console.WriteLine("Better luck next time!");

        }


    }
}