using System;

class Friends
{
    static void Main(string[] args)
    {
        // Arrays to store the ages and heights of the friends
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Taking user input for ages and heights
        Console.WriteLine("Enter age and height for Amar:");
        ages[0] = Convert.ToInt32(Console.ReadLine());
        heights[0] = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter age and height for Akbar:");
        ages[1] = Convert.ToInt32(Console.ReadLine());
        heights[1] = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter age and height for Anthony:");
        ages[2] = Convert.ToInt32(Console.ReadLine());
        heights[2] = Convert.ToDouble(Console.ReadLine());

        // Finding the youngest and the tallest
        int youngestIndex = 0;
        int tallestIndex = 0;

        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }

            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }

        // Displaying the results
        Console.WriteLine("The youngest friend is " + (youngestIndex == 0 ? "Amar" : youngestIndex == 1 ? "Akbar" : "Anthony"));
        Console.WriteLine("The tallest friend is " + (tallestIndex == 0 ? "Amar" : tallestIndex == 1 ? "Akbar" : "Anthony"));
    }
}
