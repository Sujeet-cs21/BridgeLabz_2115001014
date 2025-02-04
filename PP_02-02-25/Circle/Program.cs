using System;

class Circle
{
    public double radius;

    // Default constructor
    public Circle()
    {
        radius = 3.4;
    }

    // Parameterized constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Radius: " + radius);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle1 = new Circle(); // Default constructor
        Circle circle2 = new Circle(5.5); // Parameterized constructor

        circle1.DisplayInfo();
        Console.WriteLine("-----------------");
        circle2.DisplayInfo();
    }
}

