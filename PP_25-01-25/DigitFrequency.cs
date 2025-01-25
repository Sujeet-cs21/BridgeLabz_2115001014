using System;

class DigitFrequency
{
    static void Main(string[] args)
    {
        //Take input for a number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        //Define a frequency array of size 10
        int[] frequency = new int[10];

        //Extract each digit from the number and count its frequency
        while (number > 0)
        {
            int digit = number % 10;
            frequency[digit]++;
            number /= 10;
        }

        //Display the frequency of each digit
        Console.WriteLine("\nFrequency of each digit in the number:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine("Digit " + i + ": " + frequency[i] + " time(s)");
            }
        }
    }
}
