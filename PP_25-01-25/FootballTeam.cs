using System;

class FootballTeam
{
    static void Main(string[] args)
    {
        //an array to store the heights of 11 players
        double[] heights = new double[11];
        double sum = 0.0; // Variable to store the sum of heights

        //input for the heights of the players
        Console.WriteLine("Enter the heights of the players:");
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write("Player " + (i + 1) + ": ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
            sum += heights[i]; // Add each height to the sum
        }

        // Calculate the mean height
        double mean = sum / heights.Length;

        // Display the mean height
        Console.WriteLine("\nThe mean height of the team is: " + mean.ToString("F2") + " cm");
    }
}
