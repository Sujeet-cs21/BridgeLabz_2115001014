using System;

public class Employee
{
    // Attributes
    public string name;
    public int id;
    public double salary;

    // Method to display details
    public void DisplayDetails()
    {
        Console.WriteLine("Name: "+(name));
        Console.WriteLine("ID: "+(id));
        Console.WriteLine("Salary: "+(salary));
        Console.WriteLine("*****************************");
    }

    // Constructor
    public Employee(string name, int id, double salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create an instance of the Employee class
        Employee employee1 = new Employee("Abc", 123, 50000);

        // Display the employee details
        employee1.DisplayDetails();

        // Create another instance of the Employee class
        Employee employee2 = new Employee("Def", 456, 60000);
        employee2.DisplayDetails();
    }
}