using System;

class Grade
{
    static void Main(string[] args)
    {
        //Input the number of students
        Console.Write("Enter the number of students: ");
        int numStudents = Convert.ToInt32(Console.ReadLine());

        // Define arrays to store the marks, percentages, and grades
        int[] physics = new int[numStudents];
        int[] chemistry = new int[numStudents];
        int[] math = new int[numStudents];
        double[] percentages = new double[numStudents];
        char[] grades = new char[numStudents];
        
        // taking input for each student
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine("\nEnter marks for student " + (i + 1) + ":");
            
            int marks = -1;
            Console.Write("Enter marks for Physics (0-100): ");
            marks = Convert.ToInt32(Console.ReadLine());
            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Please enter a value between 0 and 100.");
            }
            physics[i] = marks;

            marks = -1;
            Console.Write("Enter marks for Chemistry (0-100): ");
            marks = Convert.ToInt32(Console.ReadLine());
            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Please enter a value between 0 and 100.");
            }
            chemistry[i] = marks;

            marks = -1;
            Console.Write("Enter marks for Math: ");
            marks = Convert.ToInt32(Console.ReadLine());
            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Please enter a value between 0 and 100.");
            }
            math[i] = marks;

            int totalMarks = physics[i] + chemistry[i] + math[i];
            percentages[i] = (totalMarks / 300.0) * 100;
            
            // calculating grades based on percentage
            if (percentages[i] >= 80) 
                grades[i] = 'A';
            else if (percentages[i] >= 70) 
                grades[i] = 'B';
            else if (percentages[i] >= 60) 
                grades[i] = 'C';
            else if (percentages[i] >= 50) 
                grades[i] = 'D';
            else if (percentages[i] >= 40) 
                grades[i] = 'E';
            else 
                grades[i] = 'R';
        }

        // displaying the results
        Console.WriteLine("\nStudent Results:");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine("Student " + (i + 1) + ": Marks in Physics = " + physics[i] +
                                ", Chemistry = " + chemistry[i] +
                                ", Math = " + math[i] +
                                ", Percentage = " + percentages[i].ToString("F2") + "%" +
                                ", Grade = " + grades[i]);
        }
    }
}