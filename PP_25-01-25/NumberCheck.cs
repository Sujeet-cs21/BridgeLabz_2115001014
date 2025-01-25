using System;

class NumberCheck
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];

        // Taking user input for the array
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Checking each number
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i] + " is positive and even.");
                }
                else
                {
                    Console.WriteLine(numbers[i] + " is positive and odd.");
                }
            }
            else if (numbers[i] < 0)
            {
                Console.WriteLine(numbers[i] + " is negative.");
            }
            else
            {
                Console.WriteLine(numbers[i] + " is zero.");
            }
        }

        // Comparing the first and last elements
        if (numbers[0] == numbers[numbers.Length - 1])
        {
            Console.WriteLine("The first element (" + numbers[0] + ") is equal to the last element (" + numbers[numbers.Length - 1] + ").");
        }
        else if (numbers[0] > numbers[numbers.Length - 1])
        {
            Console.WriteLine("The first element (" + numbers[0] + ") is greater than the last element (" + numbers[numbers.Length - 1] + ").");
        }
        else
        {
            Console.WriteLine("The first element (" + numbers[0] + ") is less than the last element (" + numbers[numbers.Length - 1] + ").");
        }
    }
}
