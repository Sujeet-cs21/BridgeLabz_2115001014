//4. Area of a Circle

using System;

class AreaOfCircle
{
    static void Main(string[] args)
    {
        Console.WriteLine("radius:");
        double r = double.Parse(Console.ReadLine());

        double area = Math.PI * Math.Pow(r, 2);
        Console.WriteLine("area: " + area);
    }
}
