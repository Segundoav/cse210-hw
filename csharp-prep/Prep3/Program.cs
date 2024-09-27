using System;


class Program
{
    static void Main(string[] args)
    {
        // Generate random numbers
        Random randomGenerator = new Random();

        // Variable to play again
        string playAgain = "yes";

        //Loop to play multiple times
        while (playAgain.ToLower() == "yes")

        {
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;
            int attempts = 0;


            Console.WriteLine("Welcome to the 'Guess my number' game!");

            while (guess != magicNumber)

            {
                Console.Write("What is your guess? ");

                bool isValidInput = int.TryParse(Console.ReadLine(), out guess);

                if (!isValidInput)

                {

                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                // Increase the number of attempts

                attempts++; 


                if (guess < magicNumber)

                {

                    Console.WriteLine("Higher");
                }

                else if ( guess > magicNumber)

                {
                    Console.WriteLine("Lower");
                }

                else

                {

                    Console.WriteLine($"You guessed it! It took you {attempts} guesses.");

                }


            }

            // Ask if you  want to play again

            Console.Write("Do you want to play again (yes/no)? ");
            playAgain = Console.ReadLine();

        }

        Console.WriteLine("Thanks for playing! Goobye!");

    }
}