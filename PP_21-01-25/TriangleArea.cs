using System;

class TriangleArea
{
    static void Main(string[] args)
    {
        Console.Write("Enter the base (inches): ");
        double baseInches = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height (inches): ");
        double heightInches = Convert.ToDouble(Console.ReadLine());

        double areaInches = 0.5 * baseInches * heightInches;

        double areaCm = areaInches * 6.4516;

        Console.WriteLine("The area of the triangle is " + areaInches.ToString("F2") + 
                " square inches and " + areaCm.ToString("F2") + " square centimeters");
    }
}
