using System;

class DoubleOpt
{
    static void Main(string[] args)
    {
      
        Console.Write("Enter value for a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value for b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value for c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double result1 = a + b * c;
        double result2 = a * b + c;
        double result3 = c + a / b;
        double result4 = a % b + c;

        Console.WriteLine("The results of Double Operations are " + result1.ToString("F2") + ", " 
                          + result2.ToString("F2") + ", " + result3.ToString("F2") + ", and " + result4.ToString("F2"));
    }
}
