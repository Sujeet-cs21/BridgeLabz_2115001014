using System;

class CompareStrings
{
    //Method to check it strings are equal
    public static bool IsEqual(string s1,string s2)
    {
	if(s1.Length != s2.Length)
		return false;

	for(int i=0;i<s1.Length; i++)
	{
		if(s1[i] != s2[i])
			return false;
	}
	return true;
    }
    //Main Method
    public static void Main(string[] args)
    {
	Console.WriteLine("Enter String1 : ");
	string s1 = Console.ReadLine();

	Console.WriteLine("Enter String2 : ");
	string s2 = Console.ReadLine();

	//calling IsEqual method
	Console.WriteLine("Is both Strings are equal? : "+ IsEqual(s1,s2));
    }
}