using System;

class BMICalculator1
{
    static void Main(string[] args)
    {
        // Take input for the number of persons
        Console.Write("Enter the number of persons: ");
        int numberOfPersons = Convert.ToInt32(Console.ReadLine());

        // Create a multi-dimensional array to store weight, height, and BMI
        double[,] personData = new double[numberOfPersons, 3];
        string[] weightStatus = new string[numberOfPersons];

        // Take input for weight and height for each person
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine("\nEnter details for person "+(i + 1)+":");

            double weight = -1;
            while (weight <= 0)
            {
                Console.Write("Enter weight (kg): ");
                weight = Convert.ToDouble(Console.ReadLine());
                if (weight <= 0)
                {
                    Console.WriteLine("Please enter a valid value for weight.");
                }
            }
            personData[i, 0] = weight; // Store weight

            double height = -1;
            while (height <= 0)
            {
                Console.Write("Enter height (cm): ");
                height = Convert.ToDouble(Console.ReadLine());
                if (height <= 0)
                {
                    Console.WriteLine("Please enter a positive value for height.");
                }
            }
            personData[i, 1] = height; // Store height

            // Calculate BMI (weight in kg, height in meters)
            double heightInMeters = height / 100;
            double bmi = weight / (heightInMeters * heightInMeters);
            personData[i, 2] = bmi; // Store BMI

            // Determine weight status based on BMI
            if (bmi < 18.5)
            {
                weightStatus[i] = "Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                weightStatus[i] = "Normal weight";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                weightStatus[i] = "Overweight";
            }
            else
            {
                weightStatus[i] = "Obese";
            }
        }

        // Display the height, weight, BMI, and weight status for each person
        Console.WriteLine("\nBMI and Weight Status for each person:");

        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine("\nPerson " + (i + 1) + ":");
            Console.WriteLine("Height (cm): " + personData[i, 1]);
            Console.WriteLine("Weight (kg): " + personData[i, 0]);
            Console.WriteLine("BMI: " + personData[i, 2].ToString("F2"));
            Console.WriteLine("Weight Status: " + weightStatus[i]);
        }
    }
}
