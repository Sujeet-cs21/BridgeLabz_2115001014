//2. Add Two Numbers

using System;

class Add
{
    static void Main(string[] args)
    {
	Console.WriteLine("Enter the first number:");
	int a=int.Parse(Console.ReadLine());
	Console.WriteLine("Enter the second number:");
	int b=int.Parse(Console.ReadLine());

	Console.WriteLine("sum: "+(a+b));
    }
}