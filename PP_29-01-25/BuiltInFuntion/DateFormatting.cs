using System;

public class DateFormatting
{
    public static void Main(string[] args)
    {
        // Get the current date and time
        DateTime now = DateTime.Now;

        // Format the date in different formats
        string format1 = now.ToString("dd/MM/yyyy"); 
        string format2 = now.ToString("yyyy-MM-dd");
        string format3 = now.ToString("EEE, MMM dd, yyyy");

        // Display the formatted dates
        Console.WriteLine("Format 1 (dd/MM/yyyy): " + format1);
        Console.WriteLine("Format 2 (yyyy-MM-dd): " + format2);
        Console.WriteLine("Format 3 (EEE, MMM dd, yyyy): " + format3); 
    }
}