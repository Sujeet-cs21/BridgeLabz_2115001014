using System;
using System.Collections.Generic;

namespace PP_10_02_25
{
    // Abstract class Employee
    abstract class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        protected double BaseSalary;

        public Employee(int id, string name, double baseSalary)
        {
            EmployeeId = id;
            Name = name;
            BaseSalary = baseSalary;
        }

        public abstract double CalculateSalary();

        public void DisplayDetails()
        {
            Console.WriteLine("ID: " + EmployeeId + ", Name: " + Name + ", Salary: " + CalculateSalary());
        }
    }

    // Interface IDepartment
    interface IDepartment
    {
        void AssignDepartment(string department);
        string GetDepartmentDetails();
    }

    // Full-time Employee class
    class FullTimeEmployee : Employee, IDepartment
    {
        private string Department;

        public FullTimeEmployee(int id, string name, double baseSalary) : base(id, name, baseSalary) { }

        public override double CalculateSalary()
        {
            return BaseSalary;
        }

        public void AssignDepartment(string department)
        {
            Department = department;
        }

        public string GetDepartmentDetails()
        {
            return "Department: " + Department;
        }
    }

    // Part-time Employee class
    class PartTimeEmployee : Employee, IDepartment
    {
        private string Department;
        private int WorkHours;
        private double RatePerHour;

        public PartTimeEmployee(int id, string name, double ratePerHour, int workHours) : base(id, name, 0)
        {
            RatePerHour = ratePerHour;
            WorkHours = workHours;
        }

        public override double CalculateSalary()
        {
            return RatePerHour * WorkHours;
        }

        public void AssignDepartment(string department)
        {
            Department = department;
        }

        public string GetDepartmentDetails()
        {
            return "Department: " + Department;
        }
    }

    class Class1
    {
        public static void Main1()
        {
            List<Employee> employees = new List<Employee>
            {
                new FullTimeEmployee(1, "Employee1", 5000),
                new PartTimeEmployee(2, "Employee2", 20, 80)
            };

            foreach (var emp in employees)
            {
                emp.DisplayDetails();
            }
        }
    }
}
