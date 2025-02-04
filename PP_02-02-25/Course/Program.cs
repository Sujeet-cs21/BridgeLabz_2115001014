using System;

class Course
{
    //instance variables
    public string courseName ;
    public int duration ;
    public double fee ;

    //static variable
    public static string instituteName = "Default Institute";

    // Constructor
    public Course(string courseName, int duration, double fee)
    {
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    // Method to display course details
    public void DisplayCourseDetails()
    {
        Console.WriteLine("Institute: " + instituteName);
        Console.WriteLine("Course Name: " + courseName);
        Console.WriteLine("Duration: " + duration + " weeks");
        Console.WriteLine("Fee: $" + fee);
        Console.WriteLine("-----------------");
    }

    // Static method to update institute name
    public static void UpdateinstituteName(string newName)
    {
        instituteName = newName;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Update institute name
        Course.UpdateinstituteName("Tech Academy");

        // Create course objects
        Course course1 = new Course("C# Programming", 6, 299.99);
        Course course2 = new Course("Python for Beginners", 8, 199.99);

        // Display course details
        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();
    }
}
