//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace PP_24_02_25_Reflection
//{
//    // Step 1: Define a custom attribute [Inject]
//    [AttributeUsage(AttributeTargets.Constructor)]
//    public class InjectAttribute : Attribute
//    {
//    }

//    // Step 2: Define a simple DI Container
//    public class DIContainer
//    {
//        private readonly Dictionary<Type, object> _services = new();

//        // Register a service in the container
//        public void Register<TService, TImplementation>() where TImplementation : TService
//        {
//            _services[typeof(TService)] = Activator.CreateInstance(typeof(TImplementation));
//        }

//        // Resolve an instance of the requested type, resolving constructor dependencies
//        public T Resolve<T>()
//        {
//            var serviceType = typeof(T);
//            if (_services.ContainsKey(serviceType))
//            {
//                return (T)_services[serviceType];
//            }

//            var constructor = serviceType.GetConstructors()
//                .FirstOrDefault(c => c.GetCustomAttribute<InjectAttribute>() != null);

//            if (constructor == null)
//            {
//                throw new InvalidOperationException($"No injectable constructor found for {serviceType.FullName}");
//            }

//            var parameterInfos = constructor.GetParameters();
//            var parameters = parameterInfos.Select(p => Resolve(p.ParameterType)).ToArray();

//            var instance = constructor.Invoke(parameters);
//            _services[serviceType] = instance;

//            return (T)instance;
//        }
//    }

//    // Step 3: Define classes with dependencies
//    public interface IGreetingService
//    {
//        void Greet();
//    }

//    public class GreetingService : IGreetingService
//    {
//        public void Greet() => Console.WriteLine("Hello, Dependency Injection!");
//    }

//    public class Person
//    {
//        private readonly IGreetingService _greetingService;

//        [Inject]
//        public Person(IGreetingService greetingService)
//        {
//            _greetingService = greetingService;
//        }

//        public void Greet()
//        {
//            _greetingService.Greet();
//        }
//    }

//    // Step 4: Main method to demonstrate DI
//    class Class11
//    {
//        public static void Main11()
//        {
//            // Create a DI Container
//            var container = new DIContainer();

//            // Register services in the container
//            container.Register<IGreetingService, GreetingService>();

//            // Resolve and use the Person class, with dependencies injected
//            var person = container.Resolve<Person>();
//            person.Greet();
//        }
//    }
//}
