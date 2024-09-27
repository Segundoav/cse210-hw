using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);

    }

    // Display a welcome message

    static void DisplayWelcomeMessage()

    {
        Console.WriteLine("!Welcome to the program!");
    }

    // requests and returns the username

    static string PromptUserName()

    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Requests and returns the user's favorite number

    static int PromptUserNumber()

    {
        Console.Write("Please, enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)

    {
        int square = number * number;
        return square;
    }


    static void DisplayResult(string name, int square)

    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

}