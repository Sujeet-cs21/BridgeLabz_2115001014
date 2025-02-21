using System;

namespace PP_21_02_25
{
    class Division
    {
        static int PerformDivision(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            return numerator / denominator;
        }

        public static void Main7()
        {
            try
            {
                Console.Write("Enter numerator: ");
                int numerator = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter denominator: ");
                int denominator = Convert.ToInt32(Console.ReadLine());

                int result = PerformDivision(numerator, denominator);
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input: Please enter integer values.");
            }
            finally
            {
                Console.WriteLine("Operation completed.");
            }
        }
    }
}
