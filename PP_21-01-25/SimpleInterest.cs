using System;

class SimpleInterest
{
    static void Main(string[] args)
    {
        Console.Write("Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Time: ");
        double time = Convert.ToDouble(Console.ReadLine());

        double simpleInterest = (principal * rate * time) / 100;

        Console.WriteLine("The Simple Interest is " + simpleInterest.ToString("F2") + 
                          " for Principal " + principal + ", Rate of Interest " + rate + 
                          " and Time " + time + " years.");
    }
}
