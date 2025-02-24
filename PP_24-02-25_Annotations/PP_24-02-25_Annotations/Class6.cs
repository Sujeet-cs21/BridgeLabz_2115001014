using System;
using System.Reflection;

namespace PP_24_02_25_Annotations
{
    //custom attribute
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    class ImportantMethodAttribute : Attribute
    {
        public string Level { get; }

        public ImportantMethodAttribute(string level = "HIGH")
        {
            Level = level;
        }
    }

    class Operations
    {
        [ImportantMethod] //default level "HIGH"
        public void CriticalProcess()
        {
            Console.WriteLine("Executing critical process...");
        }

        [ImportantMethod("MEDIUM")]
        public void ReviewProcess()
        {
            Console.WriteLine("Executing review process...");
        }

        public void RegularProcess()
        {
            Console.WriteLine("Executing regular process...");
        }
    }

    // using Reflection
    class Class6
    {
        public static void Main6()
        {
            Type type = typeof(Operations);
            MethodInfo[] methods = type.GetMethods();

            foreach (var method in methods)
            {
                var attribute = (ImportantMethodAttribute)Attribute.GetCustomAttribute(method, typeof(ImportantMethodAttribute));

                if (attribute != null)
                {
                    Console.WriteLine($"Method: {method.Name}, Importance Level: {attribute.Level}");
                }
            }
        }
    }
}
