using System;

public class GCDLCM
{
    // Method to calculate the GCD of two numbers
    public static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = a % b;
            a = b;
            b = temp;
        }
        return a;
    }

    // Method to calculate the LCM of two numbers
    public static int CalculateLCM(int a, int b)
    {
        // LCM = (a * b) / GCD(a, b)
        return (a * b) / CalculateGCD(a, b);
    }

    // main method
    public static void Main(string[] args)
    {
        // Get input from the user
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        // Calculate GCD and LCM
        int gcd = CalculateGCD(num1, num2);
        int lcm = CalculateLCM(num1, num2);

        // Display the result
        Console.WriteLine("GCD of " + num1 + " and " + num2 + " is: " + gcd);
        Console.WriteLine("LCM of " + num1 + " and " + num2 + " is: " + lcm);
    }
}