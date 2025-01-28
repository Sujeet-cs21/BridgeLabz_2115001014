using System;

class NumberChecker
{
    //Method to find factors and storing them in an array
    public static int[] GetFactors(int number)
    {
        int count = 0;

        //loop to count the factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0) count++;
        }

        int[] factors = new int[count];
        int index = 0;

        //loop to find and store the factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index++] = i;
            }
        }

        return factors;
    }

    //Method to find greatest factor
    public static int GetGreatestFactor(int number)
    {
        int[] factors = GetFactors(number);
        return factors[factors.Length - 2];
    }

    //Method to find the sum of factors
    public static int GetSumOfFactors(int number)
    {
        int sum = 0;
        int[] factors = GetFactors(number);

        for (int i = 0; i < factors.Length - 1; i++)
        {
            sum += factors[i];
        }

        return sum;
    }

    //Method to find product of factors
    public static int GetProductOfFactors(int number)
    {
        int product = 1;
        int[] factors = GetFactors(number);

        for (int i = 0; i < factors.Length - 1; i++)
        {
            product *= factors[i];
        }

        return product;
    }

    //Method to find product of cube of factors
    public static double GetProductOfCubeOfFactors(int number)
    {
        double product = 1;
        int[] factors = GetFactors(number);

        for (int i = 0; i < factors.Length - 1; i++)
        {
            product *= Math.Pow(factors[i], 3);
        }

        return product;
    }

    //Method to check if a number is a perfect number
    public static bool IsPerfectNumber(int number)
    {
        return GetSumOfFactors(number) == number;
    }

    //Method to check if a number is an abundant number
    public static bool IsAbundantNumber(int number)
    {
        return GetSumOfFactors(number) > number;
    }

    //Method to check if a number is a deficient number
    public static bool IsDeficientNumber(int number)
    {
        return GetSumOfFactors(number) < number;
    }

    //Method to find the factorial of a number
    public static int Factorial(int number)
    {
        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    //Method to check if a number is a strong number
    public static bool IsStrongNumber(int number)
    {
        int sumOfFactorials = 0;
        int temp = number;

        while (temp > 0)
        {
            int digit = temp % 10;
            sumOfFactorials += Factorial(digit);
            temp /= 10;
        }

        return sumOfFactorials == number;
    }
    //MAin method
    public static void Main(string[] args)
    {
        //Input for the number
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        //calling getFactors method
        int[] factors = GetFactors(number);
        foreach (int factor in factors)
        {
            Console.Write(factor + " ");
        }
        Console.WriteLine();

        //calling getGreatestFactor method
        int greatestFactor = GetGreatestFactor(number);
        Console.WriteLine("Greatest Factor: " + greatestFactor);

        //calling getSumOfFactors method
        int sumOfFactors = GetSumOfFactors(number);
        Console.WriteLine("Sum of Factors: " + sumOfFactors);

        //calling getProductOfFactors method
        int productOfFactors = GetProductOfFactors(number);
        Console.WriteLine("Product of Factors: " + productOfFactors);

        //calling getProductOfCubeOfFactors method
        double productOfCubeOfFactors = GetProductOfCubeOfFactors(number);
        Console.WriteLine("Product of Cube of Factors: " + productOfCubeOfFactors);

        //calling isPerfectNumber method
        bool isPerfect = IsPerfectNumber(number);
        Console.WriteLine("Is Perfect Number: " + isPerfect);

        //calling isAbundantNumber method
        bool isAbundant = IsAbundantNumber(number);
        Console.WriteLine("Is Abundant Number: " + isAbundant);

        //calling isDeficientNumber method
        bool isDeficient = IsDeficientNumber(number);
        Console.WriteLine("Is Deficient Number: " + isDeficient);

        //calling isStrongNumber method
        bool isStrong = IsStrongNumber(number);
        Console.WriteLine("Is Strong Number: " + isStrong);
    }
}