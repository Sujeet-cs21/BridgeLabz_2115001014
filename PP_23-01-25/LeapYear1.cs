using System;

class LeapYear1
{
    static void Main(string[] args)
    {
        // Take year input from the user
        Console.Write("Enter a year (>= 1582): ");
        int year = Convert.ToInt32(Console.ReadLine());

        // Check if year is valid for Gregorian calendar
        if (year < 1582)
        {
            Console.WriteLine("The year must be 1582 or before.");
            return;
        }

        //Using a single if statement with logical operators
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine("The year " + year + " is a Leap Year. (Checked using logical operators)");
        }
        else
        {
            Console.WriteLine("The year " + year + " is not a Leap Year. (Checked using logical operators)");
        }
    }
}
