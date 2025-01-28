using System;

public class BMICalculator
{
    // Method to calculate BMI and populate the BMI array
    public void CalculateBMI(double[,] data)
    {
        for (int i = 0; i < 10; i++)
        {
            double weight = data[i, 0];   // weight in kg
            double heightCm = data[i, 1]; // height in cm
            double heightM = heightCm / 100; // convert height to meters
            // BMI formula: BMI = weight / height^2
            double bmi = weight / (heightM * heightM);
            data[i, 2] = bmi;  // Store BMI in the third column
        }
    }

    // Method to determine the BMI status of each person
    public string[] DetermineStatus(double[,] data)
    {
        string[] statuses = new string[10];

        for (int i = 0; i < 10; i++)
        {
            double bmi = data[i, 2]; // Get the BMI
            if (bmi < 18.5)
            {
                statuses[i] = "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                statuses[i] = "Normal";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                statuses[i] = "Overweight";
            }
            else
            {
                statuses[i] = "Obese";
            }
        }

        return statuses;
    }

    static void Main(string[] args)
    {
        BMICalculator bmiCalculator = new BMICalculator();
        
        // 2D array to store weight, height, and BMI
        double[,] data = new double[10, 3];
        
        // Take user input for 10 people
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter the weight (kg) of person " + (i + 1) + ": ");
            data[i, 0] = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the height (cm) of person " + (i + 1) + ": ");
            data[i, 1] = Convert.ToDouble(Console.ReadLine());
        }
        
        // Calculate BMI
        bmiCalculator.CalculateBMI(data);
        
        // Get BMI statuses
        string[] statuses = bmiCalculator.DetermineStatus(data);

        // Display the results
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Person " + (i + 1) + ": BMI = " + data[i, 2] + ", Status = " + statuses[i]);
        }
    }
}
