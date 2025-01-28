using System;

class LeapYear
{
    // Method to check if the given year is a leap year
    public static bool IsLeapYear(int year)
    {
        // Check if the year is greater than or equal to 1582
        if (year < 1582)
        {
            Console.WriteLine("Leap year check is only applicable for years >= 1582.");
            return false;
        }

        // Check the leap year conditions:
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main(string[] args)
    {
        // Get input from the user
        Console.Write("Enter a year: ");
        
            // Use Convert.ToInt32 to convert the input to an integer
            int year = Convert.ToInt32(Console.ReadLine());

            // Check if the year is a leap year
            if (IsLeapYear(year))
            {
                Console.WriteLine(year + " is a Leap Year.");
            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year.");
            }
    }
}
