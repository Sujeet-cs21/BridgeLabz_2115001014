using System;

class BMICalculator
{
    static void Main(string[] args)
    {
        // Take input for the number of persons
        Console.Write("Enter the number of persons: ");
        int numberOfPersons = Convert.ToInt32(Console.ReadLine());

        // Create arrays to store weight, height, BMI, and weight status
        double[] weight = new double[numberOfPersons];
        double[] height = new double[numberOfPersons];
        double[] bmi = new double[numberOfPersons];
        string[] weightStatus = new string[numberOfPersons];

        // Take input for weight and height for each person
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine("\nEnter details for person "+(i + 1)+":");

            // Take input for weight and height
            Console.Write("Enter weight (kg): ");
            weight[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height (cm): ");
            height[i] = Convert.ToDouble(Console.ReadLine());

            // Convert height to meters
            double heightInMeters = height[i] / 100;

            // Calculate BMI
            bmi[i] = weight[i] / (heightInMeters * heightInMeters);

            // Determine weight status based on BMI
            if (bmi[i] <= 18.4)
            {
                weightStatus[i] = "Underweight";
            }
            else if (bmi[i] >= 18.5 && bmi[i] <= 24.9)
            {
                weightStatus[i] = "Normal weight";
            }
            else if (bmi[i] >= 25 && bmi[i] <= 39.9)
            {
                weightStatus[i] = "Overweight";
            }
            else
            {
                weightStatus[i] = "Obese";
            }
        }

        // Display the Results
        Console.WriteLine("\nBMI and Weight Status for each person:");

        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine("\nPerson " + (i + 1) + ":");
            Console.WriteLine("Height (cm): " + height[i]);
            Console.WriteLine("Weight (kg): " + weight[i]);
            Console.WriteLine("BMI: " + bmi[i].ToString("F2"));
            Console.WriteLine("Weight Status: " + weightStatus[i]);
        }
    }
}
