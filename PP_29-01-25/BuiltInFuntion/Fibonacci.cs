using System;

public class FibonacciSequence
{
    public static void GenerateFibonacci(int terms)
    {
        if (terms <= 0)
        {
            Console.WriteLine("Please enter a positive number of terms.");
            return;
        }

        int first = 0;
        int second = 1;
        Console.Write(first + " " + second + " "); 

        for (int i = 2; i < terms; i++)
        {
            int next = first + second;
            Console.Write(next + " ");
            first = second;
            second = next;
        }

        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter the number of terms: ");
        int numTerms = Convert.ToInt32(Console.ReadLine());

        GenerateFibonacci(numTerms);
    }
}