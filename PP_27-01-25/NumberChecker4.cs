using System;

class NumberChecker
{
    //Method to check if a number is a prime number
    public static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    //Method to check if a number is a neon number
    public static bool IsNeonNumber(int number)
    {
        int square = number * number;
        int sum = 0;
        while (square > 0)
        {
            sum += square % 10;
            square /= 10;
        }
        return sum == number;
    }

    //Method to check if a number is a spy number
    public static bool IsSpyNumber(int number)
    {
        int sum = 0;
        int product = 1;
        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number /= 10;
        }
        return sum == product;
    }

    //Method to check if a number is an automorphic number
    public static bool IsAutomorphicNumber(int number)
    {
        int square = number * number;
        while (number > 0)
        {
            if (number % 10 != square % 10)
            {
                return false;
            }
            number /= 10;
            square /= 10;
        }
        return true;
    }

    //Method to check if a number is a buzz number
    public static bool IsBuzzNumber(int number)
    {
        return number % 7 == 0 || number % 10 == 7;
    }
    //Main Method
    static void Main(string[] args)
    {
        //Input for the number
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Checking if the number is a prime number
        Console.WriteLine(number + (IsPrime(number) ? 
        " is a prime number." : " is not a prime number."));

        // Checking if the number is a neon number
        Console.WriteLine(number + (IsNeonNumber(number) ? 
        " is a neon number." : " is not a neon number."));

        // Checking if the number is a spy number
        Console.WriteLine(number + (IsSpyNumber(number) ? 
        " is a spy number." : " is not a spy number."));

        // Checking if the number is an automorphic number
        Console.WriteLine(number + (IsAutomorphicNumber(number) ? 
        " is an automorphic number." : " is not an automorphic number."));

        // Checking if the number is a buzz number
        Console.WriteLine(number + (IsBuzzNumber(number) ? 
        " is a buzz number." : " is not a buzz number."));

    }
}