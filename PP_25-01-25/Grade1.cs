using System;

class Grade1
{
    static void Main(string[] args)
    {
        // Input the number of students
        Console.Write("Enter the number of students: ");
		int numStudents = Convert.ToInt32(Console.ReadLine());

        // Validate the input for the number of students
		if (numStudents < 0)
            {
                Console.Write("Please enter a positive integer: ");
                numStudents = Convert.ToInt32(Console.ReadLine());
            }
        

        // Define a 2D array to store marks for Physics, Chemistry, and Math
        int[,] marks = new int[numStudents, 3];
        double[] percentages = new double[numStudents];
        char[] grades = new char[numStudents];

        // Taking input for each student
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine("\nEnter marks for student " + (i + 1) + ":");

            for (int j = 0; j < 3; j++)
            {
                string subject = j == 0 ? "Physics" : j == 1 ? "Chemistry" : "Math";
				Console.Write("Enter marks for " + subject + " (0-100): ");
                int marksInput = Convert.ToInt32(Console.ReadLine());

                // Validate the input for marks
				if (marksInput < 0 || marksInput > 100)
				{
					Console.WriteLine("Please enter a value between 0 and 100.");
					j--; // Decrement j to re-enter the marks for the same subject
					continue;
				}

                marks[i, j] = marksInput; // Store the validated mark
            }

            // Calculate total marks, percentage, and grade
            int totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentages[i] = (totalMarks / 300.0) * 100;

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

        // Displaying the results
        Console.WriteLine("\nStudent Results:");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine("Student " + (i + 1) + ": Marks in Physics = " + marks[i, 0] +
                            ", Chemistry = " + marks[i, 1] +
                            ", Math = " + marks[i, 2] +
                            ", Percentage = " + percentages[i].ToString("F2") + "%" +
                            ", Grade = " + grades[i]);
        }
    }
}
