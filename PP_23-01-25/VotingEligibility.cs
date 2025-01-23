using System;

class VotingEligibility
{
    static void Main(string[] args)
    {
        // Taking user input
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Check if the person is eligible to vote
        if (age >= 18)
        {
            // Display the result
            Console.WriteLine("The person's age is "+age+" and can vote.");
        }
        else
        {
            // Display the result
            Console.WriteLine("The person's age is "+age+" and can't vote.");
        }
    }
}