using System;

class DayOfWeek
{
    static void Main(string[] args)
    {
        // Taking user input for month, day, and year
        Console.Write("Enter the month: ");
        int m = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the day: ");
        int d = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the year: ");
        int y = Convert.ToInt32(Console.ReadLine());

        // Applying the formula
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;

        // Output the result: 0 for Sunday, 1 for Monday, and so on
        Console.WriteLine("The day of the week is: "+ d0);
    }
}
