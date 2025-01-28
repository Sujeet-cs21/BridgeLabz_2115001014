using System;

class UnitConverter2
{
    // Method to convert Fahrenheit to Celsius
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        double fahrenheit2celsius = (fahrenheit - 32) * 5 / 9;
        return fahrenheit2celsius;
    }

    // Method to convert Celsius to Fahrenheit
    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        double celsius2fahrenheit = (celsius * 9 / 5) + 32;
        return celsius2fahrenheit;
    }

    // Method to convert pounds to kilograms
    public static double ConvertPoundsToKilograms(double pounds)
    {
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }

    // Method to convert kilograms to pounds
    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kilograms2pounds = 2.20462;
        return kilograms * kilograms2pounds;
    }

    // Method to convert gallons to liters
    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    // Method to convert liters to gallons
    public static double ConvertLitersToGallons(double liters)
    {
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }

    static void Main(string[] args)
    {
        // Example usage of the conversion methods

        // Convert Fahrenheit to Celsius
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = ConvertFahrenheitToCelsius(fahrenheit);
        Console.WriteLine(fahrenheit + " Fahrenheit is equal to " + celsius + " Celsius.");

        // Convert Celsius to Fahrenheit
        Console.Write("Enter temperature in Celsius: ");
        double celsiusInput = Convert.ToDouble(Console.ReadLine());
        double fahrenheitConverted = ConvertCelsiusToFahrenheit(celsiusInput);
        Console.WriteLine(celsiusInput + " Celsius is equal to " + fahrenheitConverted + " Fahrenheit.");

        // Convert pounds to kilograms
        Console.Write("Enter weight in pounds: ");
        double pounds = Convert.ToDouble(Console.ReadLine());
        double kilograms = ConvertPoundsToKilograms(pounds);
        Console.WriteLine(pounds + " pounds is equal to " + kilograms + " kilograms.");

        // Convert kilograms to pounds
        Console.Write("Enter weight in kilograms: ");
        double kilogramsInput = Convert.ToDouble(Console.ReadLine());
        double poundsConverted = ConvertKilogramsToPounds(kilogramsInput);
        Console.WriteLine(kilogramsInput + " kilograms is equal to " + poundsConverted + " pounds.");

        // Convert gallons to liters
        Console.Write("Enter volume in gallons: ");
        double gallons = Convert.ToDouble(Console.ReadLine());
        double liters = ConvertGallonsToLiters(gallons);
        Console.WriteLine(gallons + " gallons is equal to " + liters + " liters.");

        // Convert liters to gallons
        Console.Write("Enter volume in liters: ");
        double litersInput = Convert.ToDouble(Console.ReadLine());
        double gallonsConverted = ConvertLitersToGallons(litersInput);
        Console.WriteLine(litersInput + " liters is equal to " + gallonsConverted + " gallons.");
    }
}
