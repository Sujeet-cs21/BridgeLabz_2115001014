using System;

class RocketLaunch1
{
    static void Main(string[] args)
    {
        // Take user input
        Console.Write("Enter the countdown start value: ");
        int counter = Convert.ToInt32(Console.ReadLine());

        // Countdown using a for loop
        Console.WriteLine("Starting the countdown:");
        for(int i = counter; i >= 1; i--)
        {
            Console.WriteLine(i+"...");
        }

        // Print rocket launch message
        Console.WriteLine("Rocket has launched.");
    }
}
