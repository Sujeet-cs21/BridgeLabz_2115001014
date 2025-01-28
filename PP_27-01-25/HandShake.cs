using System;

class Handshake
{
	// Method to calculate the number of handshakes
	static int CalculateHandshakes(int numberOfStudents)
	{
		return (numberOfStudents * (numberOfStudents - 1)) / 2;
	}

	// Main Method
    static void Main(string[] args)
    {
		// Input from user
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

		//calling CalculateHandshakes method
        int numberOfHandshakes = CalculateHandshakes(numberOfStudents);

		// Output
        Console.WriteLine("The maximum possible handshakes are "+ numberOfHandshakes);
    }
}
