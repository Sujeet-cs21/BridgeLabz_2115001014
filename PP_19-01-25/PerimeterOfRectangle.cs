//2. Perimeter of a Rectangle

using System;

class PerimeterOfRectangle
{
    static void Main(string[] args)
    {
        Console.WriteLine("length:");
        int l = int.Parse(Console.ReadLine());

        Console.WriteLine("width:");
        int w = int.Parse(Console.ReadLine());

        int p = 2 * (l + w);
        Console.WriteLine("perimeter: " + p);
    }
}
