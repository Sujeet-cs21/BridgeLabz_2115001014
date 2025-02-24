using System;
using System.Reflection;

namespace PP_24_02_25_Reflection
{
    public class MyClass
    {
        public int MyField;
        public string MyProperty { get; set; }

        public MyClass() { }

        public MyClass(int value) { }

        public void MyMethod() { }
        public void MyMethodWithParams(int param) { }
    }

    class Class1
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the class name ('MyClass'): ");
            string className = Console.ReadLine();

            // Dynamically load the class based on input
            Type classType = Type.GetType(className);

            // Check if the class type is found
            if (classType != null)
            {
                Console.WriteLine($"\nClass Information for '{className}':");

                // Display Methods
                Console.WriteLine("\nMethods:");
                foreach (MethodInfo method in classType.GetMethods())
                {
                    Console.WriteLine($"- {method.Name}");
                }

                // Display Fields
                Console.WriteLine("\nFields:");
                foreach (FieldInfo field in classType.GetFields())
                {
                    Console.WriteLine($"- {field.Name} ({field.FieldType})");
                }

                // Display Constructors
                Console.WriteLine("\nConstructors:");
                foreach (ConstructorInfo constructor in classType.GetConstructors())
                {
                    Console.WriteLine($"- {constructor.Name}");
                }
            }
            else
            {
                Console.WriteLine($"Class '{className}' not found.");
            }
        }
    }
}
