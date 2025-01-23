using System;

class DivisibleBy5
{
	static void Main(string[] args)
	{
		Console.WriteLine("Enter number to check: ");
		int a = Convert.ToInt32(Console.ReadLine());

		if(a % 5 == 0)
		{
			Console.WriteLine(a + " is divisible by 5");
		}
		else
		{
			Console.WriteLine(a + " is not divisible by 5");
		}
	}
}