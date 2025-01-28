using System;

class FootballTeam
{
	//Method to calculate the sum of the heights of the players
	public static int CalculateSum(int[] heights)
	{
		int sum = 0;
		foreach (int height in heights)
		{
			sum += height;
		}
		return sum;
	}

	//Method to calculate the mean height of the players
	public static double CalculateMean(int[] heights)
	{
		int sum = CalculateSum(heights);
		return sum / heights.Length;
	}

	//Method to find shortest player
	public static int FindShortestPlayer(int[] heights)
	{
		int shortest = heights[0];
		foreach (int height in heights)
		{
			if (height < shortest)
			{
				shortest = height;
			}
		}
		return shortest;
	}

	//Method to find tallest player
	public static int FindTallestPlayer(int[] heights)
	{
		int tallest = heights[0];
		foreach (int height in heights)
		{
			if (height > tallest)
			{
				tallest = height;
			}
		}
		return tallest;
	}

	//Main method
    static void Main(string[] args)
    {
        //an array to store the heights of 11 players
        int[] heights = new int[11];
		Random random = new Random();

        //input for the heights of the players
        Console.WriteLine("Enter the heights of the players:");
        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = random.Next(150, 200); // Random height between 150 and 200
			Console.WriteLine("Player " + (i + 1) + ": " + heights[i] + " cm");
        }

		//Calling the CalculateSum metho
		int sum = CalculateSum(heights);

		//Calling the CalculateMean method
		double mean = CalculateMean(heights);

		//Calling the FindShortestPlayer method
		int shortest = FindShortestPlayer(heights);

		//Calling the FindTallestPlayer method
		int tallest = FindTallestPlayer(heights);

        // Displaying the results
		Console.WriteLine("\nThe sum of the heights of the team is: " + sum + " cm");
        Console.WriteLine("The mean height of the team is: " + mean.ToString("F2") + " cm");
		Console.WriteLine("The shortest player is: " + shortest + " cm");
		Console.WriteLine("The tallest player is: " + tallest + " cm");
    }
}
