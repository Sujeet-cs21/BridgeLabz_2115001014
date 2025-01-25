using System;

class MaxElement1
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
        while (number != 0)
        {
            // If the index equals maxDigit, resize the array
            if (index == maxDigit)
            {
                maxDigit += 10; // Increase size of the array by 10
                int[] temp = new int[maxDigit]; // Create a new temporary array

                // Copy the existing elements to the temp array
                for (int i = 0; i < digits.Length; i++)
                {
                    temp[i] = digits[i];
                }

                digits = temp; // Assign the temp array to digits
            }

            // Extract the last digit and store it in the array
            digits[index] = number % 10;
            number /= 10; // Remove the last digit from the number
            index++;
        }

        int largest = -1;
        int secondLargest = -1;

        // Find the largest and second largest digits
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
