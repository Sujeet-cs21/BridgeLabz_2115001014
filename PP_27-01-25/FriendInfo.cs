using System;

class FriendInfo
{
    // Method to find the youngest among the 3 friends
    public string FindYoungest(int[] ages, string[] names)
    {
        int youngestAge = ages[0];
        string youngestFriend = names[0];

        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < youngestAge)
            {
                youngestAge = ages[i];
                youngestFriend = names[i];
            }
        }

        return youngestFriend;
    }

    // Method to find the tallest among the 3 friends
    public string FindTallest(double[] heights, string[] names)
    {
        double tallestHeight = heights[0];
        string tallestFriend = names[0];

        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > tallestHeight)
            {
                tallestHeight = heights[i];
                tallestFriend = names[i];
            }
        }

        return tallestFriend;
    }

    static void Main(string[] args)
    {
        FriendInfo friendInfo = new FriendInfo();

        // Arrays to store the ages and heights of the friends
        int[] ages = new int[3];
        double[] heights = new double[3];
        string[] names = { "Amar", "Akbar", "Anthony" };

        // Taking input for ages
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter the age of " + names[i] + ": ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Taking input for heights
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter the height of " + names[i] + " in meters: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Find and display the youngest friend
        string youngestFriend = friendInfo.FindYoungest(ages, names);
        Console.WriteLine("The youngest friend is: " + youngestFriend);

        // Find and display the tallest friend
        string tallestFriend = friendInfo.FindTallest(heights, names);
        Console.WriteLine("The tallest friend is: " + tallestFriend);
    }
}
