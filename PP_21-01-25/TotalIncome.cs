using System;

class TotalIncome
{
    static void Main(string[] args)
    {
        Console.Write("Enter salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter bonus : ");
        double bonus = Convert.ToDouble(Console.ReadLine());

        double totalIncome = salary + bonus;

        Console.WriteLine("The salary is INR " + salary.ToString("F2") + " and bonus is INR " 
                          + bonus.ToString("F2") + ". Hence Total Income is INR " 
                          + totalIncome.ToString("F2"));
    }
}
