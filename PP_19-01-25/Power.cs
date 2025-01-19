//3. Power Calculation

using System;

class Power
{
    static void Main(string[] args)
    {
        Console.WriteLine("base:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("exponent:");
        int exponent = int.Parse(Console.ReadLine());

        double result = Math.Pow(b, exponent);
        Console.WriteLine("result: " + result);
    }
}
