using System;
using System.Reflection;

namespace PP_24_02_25_Annotations
{
    //Todo attribute
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    class TodoAttribute : Attribute
    {
        public string Task { get; }
        public string AssignedTo { get; }
        public string Priority { get; }

        public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
        {
            Task = task;
            AssignedTo = assignedTo;
            Priority = priority;
        }
    }

    //Applying attribute to multiple methods
    class ProjectModule
    {
        [Todo("Implement user authentication", "ABC", "HIGH")]
        [Todo("Fix session timeout issue", "BCD", "MEDIUM")]
        public void AuthenticationModule()
        {
            Console.WriteLine("Authentication ");
        }

        [Todo("Improve database indexing", "CDE", "LOW")]
        public void DatabaseModule()
        {
            Console.WriteLine("Database optimization");
        }

        public void CompletedFeature()
        {
            Console.WriteLine("Already done.");
        }
    }

    //using Reflection
    class Class7
    {
        public static void Main7()
        {
            Type type = typeof(ProjectModule);
            MethodInfo[] methods = type.GetMethods();

            Console.WriteLine("Pending Tasks:");
            foreach (var method in methods)
            {
                var attributes = (TodoAttribute[])method.GetCustomAttributes(typeof(TodoAttribute), false);

                foreach (var attribute in attributes)
                {
                    Console.WriteLine($"Method: {method.Name}, Task: {attribute.Task}, Assigned To: {attribute.AssignedTo}, Priority: {attribute.Priority}");
                }
            }
        }
    }
}
