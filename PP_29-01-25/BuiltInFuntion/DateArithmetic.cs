using System;
using System.Globalization;

public class DateArithmetic
{
    public static void Main(string[] args)
    {
        // Get input date from the user
        Console.Write("Enter a date (dd-MM-yyyy): ");
        string inputDate = Console.ReadLine().Trim();
	DateTime date = DateTime.ParseExact(inputDate, "dd-MM-yyyy",CultureInfo.InvariantCulture);

	// Add 7 days, 1 month, and 2 years
        DateTime newDate = date.AddDays(7).AddMonths(1).AddYears(2);

        // Subtract 3 weeks (21 days)
        newDate = newDate.AddDays(-21); 

        // Display the result
        Console.WriteLine("Resulting Date: " + newDate.ToString("yyyy-MM-dd")); 

    }
}