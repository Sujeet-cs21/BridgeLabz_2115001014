using System;

class BMICalculator
{
    static void Main(string[] args)
    {
        // Get user input for weight and height
        Console.Write("Enter your weight (kg): ");
        double weight = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter your height (cm): ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        // Convert height from cm to meters
        double heightM = heightCm / 100;

        // Calculate BMI
        double bmi = weight / (heightM * heightM);

        // Print the calculated BMI
        Console.WriteLine("BMI is: " + bmi.ToString("F2"));

        // Determine weight status based on BMI
        if (bmi <= 18.4)
        {
            Console.WriteLine("status: Underweight");
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            Console.WriteLine("status: Normal weight");
        }
        else if (bmi >= 25 && bmi <= 39.9)
        {
            Console.WriteLine("status: Overweight");
        }
        else
        {
            Console.WriteLine("status: Obese");
        }
    }
}
