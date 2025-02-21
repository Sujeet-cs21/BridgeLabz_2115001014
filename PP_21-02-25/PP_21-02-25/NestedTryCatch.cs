using System;

namespace PP_21_02_25
{
    class NestedTryCatch
    {
        public static void Main9()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.Write("Enter index: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            try
            {
                try
                {
                    // May throw IndexOutOfRangeException
                    int element = numbers[index];
                    try
                    {
                        // May throw DivideByZeroException
                        int result = element / divisor;
                        Console.WriteLine("Result: " + result);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Cannot divide by zero!");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid array index!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}