using System;

class Distance
{
    //method to calculate euclidean distance
    public static double CalculateDistance(int x1, int y1, int x2, int y2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distance;
    }
    //method to find equation of a line
    public static string EquationOfLine(int x1, int y1, int x2, int y2)
    {
        //slope of the line
        double m = (y2 - y1) / (x2 - x1);
        //y-intercept of the line
        double c = y1 - m * x1;
        return "y = " + m + "x + " + c;
    }
    //main method
    static void Main(string[] args)
    {
        //input for the coordinates of two points
        Console.WriteLine("coordinates of the first point:");
        int x1 = Convert.ToInt32(Console.ReadLine());
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("coordinates of the second point:");
        int x2 = Convert.ToInt32(Console.ReadLine());
        int y2 = Convert.ToInt32(Console.ReadLine());

        //calling calculateDistance method
        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine("Distance between the two points: " + distance);

        //calling equationOfLine method
        string equation = EquationOfLine(x1, y1, x2, y2);
        Console.WriteLine("Equation of the line passing through the two points: " + equation);
    }
}