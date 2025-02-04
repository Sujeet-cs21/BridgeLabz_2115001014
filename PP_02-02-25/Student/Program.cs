using System;

class Student
{
    // Public variable
    public int rollNumber;

    // Protected variable
    protected string name;

    // Private variable
    private double CGPA;

    // Constructor
    public Student(int rollNumber, string name, double CGPA)
    {
        this.rollNumber = rollNumber;
        this.name = name;
        this.CGPA = CGPA;
    }

    // Public method to access CGPA
    public double GetCGPA()
    {
        return CGPA;
    }

    // Public method to modify CGPA
    public void SetCGPA(double newCGPA)
    {
        if (newCGPA >= 0 && newCGPA <= 10)
        {
            CGPA = newCGPA;
            Console.WriteLine("CGPA updated to: " + CGPA);
            Console.WriteLine("-----------------");
        }
        else
        {
            Console.WriteLine("Invalid CGPA value!");
        }
    }
}

class PostgraduateStudent : Student
{
    // Constructor to initialize the PostgraduateStudent
    public PostgraduateStudent(int rollNumber, string name, double CGPA)
        : base(rollNumber, name, CGPA) { }

    // Method to access the protected name field from the base class
    public void DisplayPostgraduateDetails()
    {
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("CGPA: " + GetCGPA());
        Console.WriteLine("-----------------");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Student
        Student student1 = new Student(101, "Abc", 8.5);

        // Access and modify CGPA through public methods
        Console.WriteLine("Student CGPA: " + student1.GetCGPA());
        student1.SetCGPA(9.0);

        // Create an instance of PostgraduateStudent
        PostgraduateStudent pgStudent = new PostgraduateStudent(201, "Def", 9.2);
        pgStudent.DisplayPostgraduateDetails();  // Display postgraduate student details
    }
}
