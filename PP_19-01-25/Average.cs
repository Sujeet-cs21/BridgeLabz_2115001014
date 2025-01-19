//4. Calculate Average of Three Numbers

using System;

class Average
{
    static void Main(string[] args)
    {
        Console.WriteLine("A:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("B:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("C:");
        int c = int.Parse(Console.ReadLine());

        double average = (a + b + c) / 3;
        Console.WriteLine("average: " + average);
    }
}
