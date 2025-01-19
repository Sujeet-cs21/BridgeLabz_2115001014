//3. Celsius to Fahrenheit Conversion

using System;

class Temperature 
{
    static void Main(string[] args)
    {
        Console.WriteLine("temperature in C:");
        double c = double.Parse(Console.ReadLine());

        double f = (c * 9 / 5) + 32;
        Console.WriteLine("temperature in F: " + f);
    }
}
