using System;

public class TimeZones
{
    public static void Main(string[] args)
    {
        // Get the current UTC time
        DateTimeOffset utcNow = DateTimeOffset.UtcNow;

        // Define time zones
        TimeZoneInfo gmtTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
        TimeZoneInfo istTimeZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pstTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        // Convert UTC time to local time in each time zone
        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(utcNow, gmtTimeZone);
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcNow, istTimeZone);
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcNow, pstTimeZone);

        // Display the current time in each time zone
        Console.WriteLine("GMT: " + gmtTime);
        Console.WriteLine("IST: " + istTime);
        Console.WriteLine("PST: " + pstTime);
    }
}