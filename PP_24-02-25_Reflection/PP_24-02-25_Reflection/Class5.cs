using System;
using System.Reflection;

namespace PP_24_02_25_Reflection
{
    class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
        
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    class Class5
    {
        public static void Main5()
        {
            MathOperations mathOperations = new MathOperations();

            // Prompt the user to enter a method name (Add, Subtract, Multiply)
            Console.WriteLine("Enter the operation you want to perform (Add, Subtract, Multiply): ");
            string operation = Console.ReadLine();

            // Prompt the user to enter two numbers
            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            // Using  Reflection to get the Type of MathOperations
            Type mathType = typeof(MathOperations);

            // Using Reflection to get the method based on user input
            MethodInfo methodInfo = mathType.GetMethod(operation, BindingFlags.Public | BindingFlags.Instance);

            // Check if the method exists
            if (methodInfo != null)
            {
                // Dynamically invoke the method
                object result = methodInfo.Invoke(mathOperations, new object[] { num1, num2 });

                // Display the result
                Console.WriteLine($"Result of {operation}({num1}, {num2}) = {result}");
            }
            else
            {
                Console.WriteLine("Invalid operation entered.");
            }
        }
    }
}
