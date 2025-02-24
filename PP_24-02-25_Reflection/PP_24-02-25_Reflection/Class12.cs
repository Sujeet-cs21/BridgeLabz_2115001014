using System;
using System.Diagnostics;
using System.Reflection;

namespace PP_24_02_25_Reflection
{
    public class SampleClass
    {
        public void MethodOne()
        {
            Console.WriteLine("Executing MethodOne...");
            System.Threading.Thread.Sleep(1000);
        }

        public void MethodTwo()
        {
            Console.WriteLine("Executing MethodTwo...");
            System.Threading.Thread.Sleep(500);
        }
    }

    public class MethodExecutionTimer
    {
        // Method to measure the execution time
        public static void MeasureExecutionTime(object target, string methodName)
        {
            // Get the type of the target object
            Type targetType = target.GetType();

            // Get the method info for the specified method
            MethodInfo method = targetType.GetMethod(methodName);

            if (method == null)
            {
                Console.WriteLine($"Method {methodName} not found in {targetType.FullName}.");
                return;
            }

            //stopwatch to measure the execution time
            Stopwatch stopwatch = Stopwatch.StartNew();

            // Invoking the method dynamically using reflection
            method.Invoke(target, null);

            // Stop the stopwatch after method execution
            stopwatch.Stop();

            // Output the execution time
            Console.WriteLine($"Method {methodName} executed in {stopwatch.ElapsedMilliseconds} ms.");
        }
    }

    class Class12
    {
        public static void Main12()
        {
            var sampleObject = new SampleClass();

            // Measuring the execution time of MethodOne
            MethodExecutionTimer.MeasureExecutionTime(sampleObject, "MethodOne");

            // Measuring the execution time of MethodTwo
            MethodExecutionTimer.MeasureExecutionTime(sampleObject, "MethodTwo");
        }
    }
}
