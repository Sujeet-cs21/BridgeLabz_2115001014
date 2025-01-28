using System;

public class VotingEligibility
{
    // Method to check if the student can vote based on their age
    public bool CanStudentVote(int age)
    {
        if (age < 0)
        {
            // If the age is negative, return false (invalid age)
            return false;
        }
        else if (age >= 18)
        {
            // If the age is 18 or greater, the student can vote
            return true;
        }
        else
        {
            // If the age is less than 18, the student cannot vote
            return false;
        }
    }

    static void Main(string[] args)
    {
        // Create an instance of the StudentVoteChecker class
        VotingEligibility voteChecker = new VotingEligibility();

        // Array to store the ages of 10 students
        int[] studentAges = new int[10];

        // Loop through the array to take input for each student's age
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter age of student " + (i + 1) + ": ");
            studentAges[i] = Convert.ToInt32(Console.ReadLine());
            
            // Check if the student can vote and display the result
            if (voteChecker.CanStudentVote(studentAges[i]))
            {
                Console.WriteLine("Student " + (i + 1) + " can vote.");
            }
            else
            {
                Console.WriteLine("Student " + (i + 1) + " cannot vote.");
            }
        }
    }
}
