using System;

public class NumberGuessingGame
{
    // Main method
    public static void Main(string[] args)
    {
        // think of a number between 1 and 100
        Console.WriteLine("Think of a number between 1 and 100.");
        Convert.ToInt32(Console.ReadLine());

        // set the range of possible numbers
        int min = 1;
        int max = 100;
        int guessCount = 0;

        //
        while (true)
        {
            //calling GenerateGuess method
            int guess = GenerateGuess(min, max);
            guessCount++;

            Console.WriteLine("Guess " + guessCount + ": " + guess);

            //calling GetFeedback method
            string feedback = GetFeedback();

            if (feedback.ToLower() == "correct")
            {
                Console.WriteLine("I guessed your number in " + guessCount + " tries!");
                break;
            }
            else if (feedback.ToLower() == "high")
            {
                max = guess - 1;
            }
            else if (feedback.ToLower() == "low")
            {
                min = guess + 1;
            }
            else
            {
                Console.WriteLine("Please enter 'high', 'low', or 'correct'.");
            }
        }
    }

    // Method to generate a random guess
    static int GenerateGuess(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max + 1);
    }

    // Method to get feedback from the user
    static string GetFeedback()
    {
        Console.Write("Was the guess high, low, or correct? ");
        return Console.ReadLine();
    }
}