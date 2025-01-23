using System;

class EmployeeBonus
{
    static void Main(string[] args)
    {
        // Input salary and years of service
        Console.Write("Enter the employee's salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the years of service: ");
        int yearsOfService = Convert.ToInt32(Console.ReadLine());

        // Initialize bonus
        double bonus = 0;

        // Check eligibility for bonus
        if (yearsOfService > 5)
        {
            bonus = salary * 0.05; // 5% of salary
        }

        // Output bonus amount
        if (bonus > 0)
        {
            Console.WriteLine("The bonus amount is " + bonus.ToString("F2"));
        }
        else
        {
            Console.WriteLine("No bonus is applicable.");
        }
    }
}
