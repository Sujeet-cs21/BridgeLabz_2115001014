using System;

class LeapYear
{
    static void Main(string[] args)
    {
        // Take year input from the user
        Console.Write("Enter a year (>= 1582): ");
        int year = Convert.ToInt32(Console.ReadLine());

        // Check if year is valid for Gregorian calendar
        if (year < 1582)
        {
            Console.WriteLine("The year must be 1582 or later.");
            return;
        }

        //Using multiple if-else statements
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine("The year " + year + " is a Leap Year.");
                }
                else
                {
                    Console.WriteLine("The year " + year + " is not a Leap Year.");
                }
            }
            else
            {
                Console.WriteLine("The year " + year + " is a Leap Year.");
            }
        }
        else
        {
            Console.WriteLine("The year " + year + " is not a Leap Year.");
        }
    }
}
