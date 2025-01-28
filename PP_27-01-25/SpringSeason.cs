using System;

class SpringSeason
{
	// Method to check if the date falls in the Spring Season (March 20 to June 20)
	static bool IsSpringSeason(int month, int day)
	{
		return ((month == 3 && day >= 20) || (month > 3 && month < 6) || (month == 6 && day <= 20));
	}
    static void Main(string[] args)
    {
        // Take user input for month and day
        Console.Write("Enter the month: ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the day: ");
        int day = Convert.ToInt32(Console.ReadLine());

		// Calling IsSpringSeason method
		bool result = IsSpringSeason(month, day);

		// Output
		Console.WriteLine(result ? "It's a Spring Season" : "Not a Spring Season");
        
    }
}
