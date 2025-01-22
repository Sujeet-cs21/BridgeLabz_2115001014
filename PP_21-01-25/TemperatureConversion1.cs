using System;

class TemperatureConversion1
{
    static void Main(string[] args)
    {
        Console.Write("Enter the temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        double celsiusResult = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine("The " + fahrenheit + " Fahrenheit is " + celsiusResult.ToString("F2") + " Celsius");
    }
}
