using System;

class VotingEligibility
{
    static void Main(string[] args)
    {
        // Define an array to store the ages of 10 students
        int[] studentAges = new int[10];

        // Loop to take input for each student's age
        for (int i = 0; i < studentAges.Length; i++)
        {
            Console.Write("Enter the age of student " + (i + 1) + ": ");
            studentAges[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nChecking voting eligibility...\n");

        // Loop to check voting eligibility for each student
        for (int i = 0; i < studentAges.Length; i++)
        {
            if (studentAges[i] < 0) // Invalid age check
            {
                Console.WriteLine("Invalid age entered for student " + (i + 1) + ": " + studentAges[i]);
            }
            else if (studentAges[i] >= 18) // Age 18 or above can vote
            {
                Console.WriteLine(studentAges[i] + " can vote.");
            }
            else // Below 18 cannot vote
            {
                Console.WriteLine(studentAges[i] + " cannot vote.");
            }
        }
    }
}
