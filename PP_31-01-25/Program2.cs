using System;

// Circle Class
public class Circle
{
    // Attributes
    public double radius;

    // Constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Methods to calculate area
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    // Method to calculate circumference
    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }

    // Method to display area
    public void DisplayArea()
    {
        double area = CalculateArea();
        Console.WriteLine("The area of the circle is: " + area.ToString("F2"));
    }

    // Method to display circumference
    public void DisplayCircumference()
    {
        double circumference = CalculateCircumference();
        Console.WriteLine("The circumference of the circle is: " + circumference.ToString("F2"));
    }
}

// Main Class
public class Program
{
    // Main Method
    public static void Main(string[] args)
    {
        // Create an instance of the Circle class
        Circle circle1 = new Circle(7);
        circle1.DisplayArea();
        circle1.DisplayCircumference();

        Console.WriteLine("*****************************");

        // Create another instance of the Circle class
        Circle circle2 = new Circle(3.5);
        circle2.DisplayArea();
        circle2.DisplayCircumference();


    }
}