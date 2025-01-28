using System;

class CollinearPoints
{
    // Method to check if three points are collinear using the slope formula
    public static bool AreCollinear(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        // Calculate the slopes of the lines formed by the points
        double slope1 = (y2 - y1) / (double)(x2 - x1);
        double slope2 = (y3 - y2) / (double)(x3 - x2);
        double slope3 = (y3 - y1) / (double)(x3 - x1);

        // Check if the slopes are equal
        return slope1 == slope2 && slope2 == slope3;
    }

    //method to check if three points are collinear using the area of triangle formula
    public static bool AreCollinear2(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        // Calculate the area of the triangle formed by the points
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

        // Check if the area is zero
        return area == 0;
    }

    static void Main()
    {
        // Input for the coordinates of three points
        Console.WriteLine("Coordinates of the first point:");
        int x1 = Convert.ToInt32(Console.ReadLine());
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Coordinates of the second point:");
        int x2 = Convert.ToInt32(Console.ReadLine());
        int y2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Coordinates of the third point:");
        int x3 = Convert.ToInt32(Console.ReadLine());
        int y3 = Convert.ToInt32(Console.ReadLine());

        // Check if the points are collinear
        bool collinear = AreCollinear(x1, y1, x2, y2, x3, y3);
        Console.WriteLine("Are the points collinear? " + collinear);

        // Check if the points are collinear using the second method
        bool collinear2 = AreCollinear2(x1, y1, x2, y2, x3, y3);
        Console.WriteLine("Are the points collinear? " + collinear2);
    }
}