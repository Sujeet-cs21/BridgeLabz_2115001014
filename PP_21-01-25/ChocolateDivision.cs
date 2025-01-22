using System;

class ChocolateDivision
{
    static void Main()
    {
        Console.Write("total number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("total number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;
        
        Console.WriteLine("The number of chocolates each child gets is " 
                          + chocolatesPerChild + " and the number of remaining chocolates is " 
                          + remainingChocolates + ".");
    }
}
