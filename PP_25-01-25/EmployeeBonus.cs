using System;

class EmployeeBonus
{
    static void Main(string[] args)
    {
        // Define the required arrays
        double[] salary = new double[10];
        int[] yearsOfService = new int[10];
        double[] bonus = new double[10];
        double[] newSalary = new double[10];
        
        // Define variables to store total bonus, total old salary, and total new salary
        double totalBonus = 0, totalOldSalary = 0, totalNewSalary = 0;

        // Loop to get input from the user for salary and years of service
        for (int i = 0; i < 10; i++)
        {
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("Enter the salary and years of service for employee "+(i + 1)+":");

                Console.Write("Salary: ");
                string salaryInput = Console.ReadLine();
                Console.Write("Years of Service: ");
                string yearsInput = Console.ReadLine();

                // Validate input for salary and years of service
                if (double.TryParse(salaryInput, out salary[i]) && salary[i] > 0 &&
                    int.TryParse(yearsInput, out yearsOfService[i]) && yearsOfService[i] >= 0)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Please enter valid salary (positive number) and years of service (non-negative integer).");
                }
            }
        }

        // Loop to calculate bonus, new salary, and totals
        for (int i = 0; i < 10; i++)
        {
            // Calculate bonus based on years of service
            if (yearsOfService[i] > 5)
            {
                bonus[i] = salary[i] * 0.05; // 5% bonus for employees with more than 5 years of service
            }
            else
            {
                bonus[i] = salary[i] * 0.02; // 2% bonus for employees with 5 or fewer years of service
            }

            // Calculate new salary
            newSalary[i] = salary[i] + bonus[i];

            // Add to total bonus, total old salary, and total new salary
            totalBonus += bonus[i];
            totalOldSalary += salary[i];
            totalNewSalary += newSalary[i];
        }

        // Print the total bonus payout, total old salary, and total new salary
        Console.WriteLine("\nTotal Bonus Payout: " + totalBonus);
        Console.WriteLine("Total Old Salary: " + totalOldSalary);
        Console.WriteLine("Total New Salary: " + totalNewSalary);
    }
}
