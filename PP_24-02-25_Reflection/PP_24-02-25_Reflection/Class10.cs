using System;

namespace PP_24_02_25_Reflection
{
    public interface IGreeting
    {
        void SayHello();
    }

    public class Greeting : IGreeting
    {
        public void SayHello()
        {
            Console.WriteLine("Hello, world!");
        }
    }

    public class LoggingProxy : IGreeting
    {
        private readonly IGreeting _target;

        public LoggingProxy(IGreeting target)
        {
            _target = target;
        }

        public void SayHello()
        {
            // Log the method name before invoking it
            Console.WriteLine($"Method {nameof(SayHello)} is being called.");

            // Invoke the actual method on the target
            _target.SayHello();
        }
    }

    class Class10
    {
        public static void Main10()
        {
            // Create the actual object
            IGreeting greeting = new Greeting();

            // Create a proxy object that wraps the original object
            IGreeting proxy = new LoggingProxy(greeting);

            // Call the method on the proxy (this will log and then execute the actual method)
            proxy.SayHello();
        }
    }
}
