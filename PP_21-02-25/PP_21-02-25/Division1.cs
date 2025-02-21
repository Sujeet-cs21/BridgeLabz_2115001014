using System;

namespace PP_21_02_25
{
    class Division1
    {
        public static void Main2()
        {
            try
            {
                Console.Write("Enter Numerator: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Denominator: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter numeric values.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }

}
