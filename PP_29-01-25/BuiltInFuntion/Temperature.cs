using System;

public class Temperature
{
    // Method to convert Fahrenheit to Celsius
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    // Method to convert Celsius to Fahrenheit
    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // main method
    public static void Main(string[] args)
    {
        //input for conversion type
        Console.WriteLine("Select conversion type:");
        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");
        Console.Write("Enter your choice (1 or 2): ");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = FahrenheitToCelsius(fahrenheit);
            Console.WriteLine(fahrenheit + "°F is equal to " + celsius + "°C");
        }
        else if (choice == 2)
        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = CelsiusToFahrenheit(celsius);
            Console.WriteLine(celsius + "°C is equal to " + fahrenheit + "°F");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}