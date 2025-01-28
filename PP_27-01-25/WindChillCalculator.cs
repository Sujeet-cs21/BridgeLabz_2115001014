using System;

class WindChillCalculator
{
    // Method to calculate the wind chill temperature
    public static double CalculateWindChill(double temperature, double windSpeed)
    {
        // Wind chill formula
        double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
        return windChill;
    }

    static void Main(string[] args)
    {
        // Get the temperature from the user
        Console.Write("Enter the temperature: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        // Get the wind speed from the user
        Console.Write("Enter the wind speed: ");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        // Check if wind speed is valid
        if (windSpeed >= 0)
        {
            // Calling CalculateWindChill method
            double windChill = CalculateWindChill(temperature, windSpeed);

            // Display the result
            Console.WriteLine("The wind chill temperature is: " + windChill + " °F");
        }
        else
        {
            Console.WriteLine("Wind speed cannot be negative.");
        }
    }
}
