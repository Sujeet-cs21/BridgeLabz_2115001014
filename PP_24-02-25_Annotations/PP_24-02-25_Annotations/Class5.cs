using System;
using System.Reflection;

namespace PP_24_02_25_Annotations
{
    //repeatable attribute
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    class BugReportAttribute : Attribute
    {
        public string Description { get; }

        public BugReportAttribute(string description)
        {
            Description = description;
        }
    }

    class SoftwareModule
    {
        //Applying the attribute multiple times

        [BugReport("First BugReport")]
        [BugReport("Second BugReport")]
        public void ProcessData()
        {
            Console.WriteLine("Processing data...");
        }
    }

    // using Reflection
    class Class5
    {
        public static void Main5()
        {
            MethodInfo methodInfo = typeof(SoftwareModule).GetMethod("ProcessData");

            if (methodInfo != null)
            {
                var attributes = (BugReportAttribute[])methodInfo.GetCustomAttributes(typeof(BugReportAttribute), false);

                foreach (var attribute in attributes)
                {
                    Console.WriteLine($"Bug Report: {attribute.Description}");
                }
            }
        }
    }
}
