using System;
using System.Reflection;

namespace PP_24_02_25_Annotations
{
    // a custom attribute
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    class TaskInfoAttribute : Attribute
    {
        public int Priority { get; }
        public string AssignedTo { get; }

        public TaskInfoAttribute(int priority, string assignedTo)
        {
            Priority = priority;
            AssignedTo = assignedTo;
        }
    }

    class TaskManager
    {
        [TaskInfo(1, "Abcd")]
        public void CompleteTask()
        {
            Console.WriteLine("Task completed.");
        }
    }

    // using Reflection
    class Class4
    {
        public static void Main4()
        {
            MethodInfo methodInfo = typeof(TaskManager).GetMethod("CompleteTask");
            
            if (methodInfo != null)
            {
                var attribute = (TaskInfoAttribute)Attribute.GetCustomAttribute(methodInfo, typeof(TaskInfoAttribute));

                if (attribute != null)
                {
                    Console.WriteLine($"Task Priority: {attribute.Priority}");
                    Console.WriteLine($"Assigned To: {attribute.AssignedTo}");
                }
            }
        }
    }
}
