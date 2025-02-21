using System;

namespace PP_21_02_25
{
    class PropogateExceptions
    {
        static int PerformDivision(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            return numerator / denominator;
        }

        static void Method1()
        {
            throw new ArithmeticException("Division by zero.");
        }

        static void Method2()
        {
            Method1();
        }

        public static void Main8()
        {
            try
            {
                Console.Write("Enter numerator: ");
                int numerator = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter denominator: ");
                int denominator = Convert.ToInt32(Console.ReadLine());

                int result = PerformDivision(numerator, denominator);
                Console.WriteLine($"Result: {result}");

                Method2();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Invalid input: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input: Please enter numeric values.");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Handled exception in Main: " + ex.Message);
            }
        }
    }

}
