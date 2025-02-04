using System;

class Employee
{
    // Public variable
    public int employeeID;

    // Protected variable
    protected string department;

    // Private variable
    private decimal salary;

    // Constructor
    public Employee(int employeeID, string department, decimal salary)
    {
        this.employeeID = employeeID;
        this.department = department;
        this.salary = salary;
    }

    // Public method to get the salary
    public decimal GetSalary()
    {
        return salary;
    }

    // Public method to modify the salary
    public void SetSalary(decimal newSalary)
    {
        if (newSalary >= 0)
        {
            salary = newSalary;
            Console.WriteLine("Salary updated to: " + salary);
        }
        else
        {
            Console.WriteLine("Salary cannot be negative!");
        }
    }
}

class Manager : Employee
{
    // Constructor to initialize the Manager class
    public Manager(int employeeID, string department, decimal salary)
        : base(employeeID, department, salary) { }

    // Method to display Manager details 
    public void DisplayManagerDetails()
    {
        Console.WriteLine("Employee ID: " + employeeID); // Accessible (public)
        Console.WriteLine("Department: " + department); // Accessible (protected)
        Console.WriteLine("Salary: " + GetSalary());   // Accessible via public GetSalary method
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of Employee
        Employee employee1 = new Employee(101, "HR", 50000m);

        // Access and modify the salary using public methods
        Console.WriteLine("Original Salary: " + employee1.GetSalary());
        employee1.SetSalary(55000m);

        // Create an instance of Manager 
        Manager manager1 = new Manager(102, "IT", 70000m);
        manager1.DisplayManagerDetails();  // Display Manager details
    }
}
