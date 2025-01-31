using System;
using System.Globalization;

public class DateComparison
{
    public static void Main(string[] args)
    {
        // Get two date inputs from the user
        Console.Write("Enter the first date (dd-MM-yyyy): ");
        string inputDate1 = Console.ReadLine().Trim();

        Console.Write("Enter the second date (dd-MM-yyyy): ");
        string inputDate2 = Console.ReadLine().Trim();

        // Parse the input date strings
	DateTime date1 = DateTime.ParseExact(inputDate1, "dd-MM-yyyy",CultureInfo.InvariantCulture);
	DateTime date2 = DateTime.ParseExact(inputDate2, "dd-MM-yyyy",CultureInfo.InvariantCulture);

	// Compare the dates
	int comparisonResult = DateTime.Compare(date1, date2);

	// Display the comparison result using concatenation
	if (comparisonResult < 0)
	{
	    Console.WriteLine("The first date (" + date1 + ") is before the second date (" + date2 + ")."); 
	}
	else if (comparisonResult > 0)
	{
	    Console.WriteLine("The first date (" + date1 + ") is after the second date (" + date2 + ")."); 
	}
	else
	{
	    Console.WriteLine("The first date (" + date1 + ") is the same as the second date (" + date2 + ")."); 
	}

    }
}