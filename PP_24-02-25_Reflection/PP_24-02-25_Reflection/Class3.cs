using System;
using System.Reflection;

namespace PP_24_02_25_Reflection
{
    class Calculator
    {
        // Private method
        private int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    class Class3
    {
        public static void Main3()
        {
            Calculator calculator = new Calculator();

            // Using Reflection to access the private method 'Multiply'
            Type calculatorType = typeof(Calculator);
            MethodInfo multiplyMethod = calculatorType.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

            // Check if the method found
            if (multiplyMethod != null)
            {
                //parameters for the Multiply method
                object[] parameters = { 5, 10 };

                // Invoking the private method and get the result
                object result = multiplyMethod.Invoke(calculator, parameters);

                // Display the result
                Console.WriteLine($"Result : {result}");
            }
            else
            {
                Console.WriteLine("Method not found.");
            }
        }
    }
}
