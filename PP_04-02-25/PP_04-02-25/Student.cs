using System;

namespace PP_04_02_25
{
    class Student
    {
        // Static variable shared across all students
        public static string UniversityName = "GLA University";

        // Static variable to track total students
        private static int totalStudents = 0;

        // Readonly variable for Roll Number
        public readonly int RollNumber;

        // Student details
        public string Name;
        public string Grade;

        // Constructor
        public Student(string Name, int RollNumber, string Grade)
        {
            // Using 'this' to initialize fields
            this.Name = Name;
            this.RollNumber = RollNumber;
            this.Grade = Grade;

            totalStudents++;
        }

        // Static method to display total students
        public static void DisplayTotalStudents()
        {
            Console.WriteLine("Total Students: " + totalStudents);
            Console.WriteLine("********************");
        }

        // Method to display student details
        public void DisplayStudentDetails()
        {
            // Using 'is' operator to check instance type
            if (this is Student)
            {
                Console.WriteLine("University Name: " + UniversityName);
                Console.WriteLine("Student Name: " + Name);
                Console.WriteLine("Roll Number: " + RollNumber);
                Console.WriteLine("Grade: " + Grade);
                Console.WriteLine("********************");
            }
            else
            {
                Console.WriteLine("Invalid student object.");
            }
        }
        public static void RunStudentClass()
        {
            // Creating student instances
            Student student1 = new Student("Student1", 101, "A");
            Student student2 = new Student("Student2", 102, "B");

            // Display student details
            student1.DisplayStudentDetails();
            student2.DisplayStudentDetails();

            // Display total students
            Student.DisplayTotalStudents();
        }
    }
}
