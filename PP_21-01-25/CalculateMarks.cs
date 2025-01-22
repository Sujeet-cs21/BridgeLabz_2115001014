using System;

class CalculateMarks
{
    static void Main(string[] args)
    {
        int mathsMarks = 94;
        int physicsMarks = 95;
        int chemistryMarks = 96;

        double averageMarks = (mathsMarks + physicsMarks + chemistryMarks) / 3.0;

        Console.WriteLine("Sam’s average mark in PCM is "+averageMarks+".");
    }
}