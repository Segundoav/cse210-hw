using System;

using System.Collections.Generic;

namespace Prep4

{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int input;

            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            do
            {
                Console.Write("Enter number: ");
                input = int.Parse(Console.ReadLine());

                //We add  number only if it is not 0

                if (input != 0)

                {

                    numbers.Add(input);
                }

            } while (input != 0);

            // Calculate the sum


            int sum = 0;
            foreach (int number in numbers)

            {
                sum += number;
            }

            Console.WriteLine($"The sum is: {sum}");


            double average = numbers.Count > 0 ? (double)sum / numbers.Count : 0;
            Console.WriteLine($"The average is: {average}");


            int maxNumber = numbers.Count > 0 ? numbers [0] : 0;
            foreach (int number in numbers)

            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine($"The largest number is: {maxNumber}");


            // Find the smallest positive number
            int smallestPositive = int.MaxValue;
            foreach (int number in numbers)

            {
                if (number > 0 && number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }

            if (smallestPositive == int.MaxValue)
            {

                Console.WriteLine("There are no positive numbers.");
            }
            else
            {

                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }


            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int number in numbers)

            {
                Console.WriteLine(number);
            }

        }
    }
}
