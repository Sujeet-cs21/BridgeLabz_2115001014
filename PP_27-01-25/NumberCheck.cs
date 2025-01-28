using System;

class NumberCheck
{
	// Method to check if the number is positive, negative, or zero
	static int CheckNumber(int number)
	{
		if (number > 0)
		{
			return 1;
		}
		else if (number < 0)
		{
			return -1;
		}
		else
		{
			return 0;
		}
	}
    static void Main(string[] args)
    {
        // Taking user input
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

		// Calling CheckNumber method
		int result = CheckNumber(number);
        
		// Output
        Console.WriteLine("The number is " + (result == 1 ? "positive" : result == -1 ? "negative" : "zero"));
    }
}
