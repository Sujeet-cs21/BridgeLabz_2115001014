using System;

namespace PP_04_02_25
{
    class Employee
    {
        // Static variable shared by all employees
        public static string CompanyName = "Static Company";

        // Static variable to track total employees
        private static int totalEmployees = 0;

        // Readonly variable for employee ID
        public readonly int Id;

        // Employee details
        public string Name;
        public string Designation;

        // Constructor
        public Employee(string Name, int Id, string Designation)
        {
            // Using 'this' to initialize fields
            this.Name = Name;
            this.Id = Id;
            this.Designation = Designation;

            totalEmployees++;
        }

        // Static method to display total employees
        public static void DisplayTotalEmployees()
        {
            Console.WriteLine("Total Employees: " + totalEmployees);
            Console.WriteLine("********************");
        }

        // Method to display employee details
        public void DisplayEmployeeDetails()
        {
            // Using 'is' operator to check instance type
            if (this is Employee)
            {
                Console.WriteLine("Company Name: " + CompanyName);
                Console.WriteLine("Employee Name: " + Name);
                Console.WriteLine("Employee ID: " + Id);
                Console.WriteLine("Designation: " + Designation);
                Console.WriteLine("********************");
            }
            else
            {
                Console.WriteLine("Invalid employee object.");
            }
        }
        public static void RunEmployeeClass()
        {
            // Creating employee instances
            Employee emp1 = new Employee("Employee1", 101, "Designation1");
            Employee emp2 = new Employee("Employee2", 102, "Designation2");

            // Display employee details
            emp1.DisplayEmployeeDetails();
            emp2.DisplayEmployeeDetails();

            // Display total employees
            Employee.DisplayTotalEmployees();
        }
    }
}
