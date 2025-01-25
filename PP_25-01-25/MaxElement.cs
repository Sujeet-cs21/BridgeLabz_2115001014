using System;

class MaxElement
{
    static void Main(string[] args)
    {
        //user input for the number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Define the variables
        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;

        // Loop to extract the digits and store them in the array
        while (number != 0 && index < maxDigit)
        {
            digits[index] = number % 10;
            number /= 10;
            index++;
        }

        int largest = -1;
        int secondLargest = -1;

        // Finding the largest and second largest digits
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        // Display the results
        Console.WriteLine("The largest digit is: " + largest);
        Console.WriteLine("The second largest digit is: " + secondLargest);
    }
}
