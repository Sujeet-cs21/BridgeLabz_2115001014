using System;

namespace PP_24_02_25_Reflection
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Class4
    {
        public static void Main4()
        {
            // Using Reflection to get the Type of the Student class
            Type studentType = typeof(Student);

            // Dynamically creating an instance of the Student class using Activator.CreateInstance
            object studentInstance = Activator.CreateInstance(studentType, "Student1", 20);

            // Casting the instance to the Student type
            Student student = (Student)studentInstance;

            // Display the student's information
            student.DisplayInfo();
        }
    }
}
