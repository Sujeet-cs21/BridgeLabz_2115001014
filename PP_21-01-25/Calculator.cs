using System;

class Calculator
{
    static void Main(string[] args)
    {
      
        Console.Write("Enter the 1st number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the 2nd number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        double add = number1 + number2;
        double subtract = number1 - number2;
        double multiply = number1 * number2;
        double divide = (number2 != 0) ? number1 / number2 : double.NaN;

        Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers " + number1 + " and " + number2 + 
                  " is " + add + ", " + subtract + ", " + multiply + ", and " + divide);

    }
}
