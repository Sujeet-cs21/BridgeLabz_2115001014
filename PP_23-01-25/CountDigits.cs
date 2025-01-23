using System;

class CountDigits
{
    static void Main(string[] args)
    {
        // Taking user input
        Console.Write("Enter a number: ");
         // Using Math.Abs to handle negative numbers
        int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        
        int count = 0;

        // Using a loop to count the number of digits
        while (number != 0)
        {
            // Remove the last digit from the number
            number = number / 10;

            // Increase the count by 1
            count++;
        }

        // If the number is 0,it has 1 digit
        if (count == 0)
        {
            count = 1;
        }

        // Display the result
        Console.WriteLine("The number of digits is: " + count);
    }
}
