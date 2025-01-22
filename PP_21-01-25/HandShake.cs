using System;

class Handshake
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        int numberOfHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        Console.WriteLine("The maximum possible handshakes are "+ numberOfHandshakes);
    }
}
