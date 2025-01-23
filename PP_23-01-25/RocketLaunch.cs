using System;

class RocketLaunch
{
    static void Main(string[] args)
    {
        // Take user input
        Console.Write("Enter the countdown start value: ");
        int counter = Convert.ToInt32(Console.ReadLine());

        // Countdown using a while loop
        Console.WriteLine("Starting the countdown:");
        while (counter >= 1)
        {
            Console.WriteLine(counter+"...");
            counter--;
        }

        // Print rocket launch message
        Console.WriteLine("Rocket has launched.");
    }
}
