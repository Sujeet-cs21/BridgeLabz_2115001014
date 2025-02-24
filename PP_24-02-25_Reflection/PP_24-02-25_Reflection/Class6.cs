using System;

namespace PP_24_02_25_Reflection
{
    //custom attribute
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; }

        public AuthorAttribute(string name)
        {
            Name = name;
        }
    }

    //Applying the custom attribute to a class
    [Author("Author1")]
    public class MyClass
    {
        public void DisplayInfo()
        {
            Console.WriteLine("This is MyClass.");
        }
    }

    class Class6
    {
        public static void Main6()
        {
            //Using Reflection to retrieve the Author attribute applied to MyClass
            Type classType = typeof(MyClass);

            // Retrieve the custom attribute
            AuthorAttribute authorAttribute = (AuthorAttribute)Attribute.GetCustomAttribute(classType, typeof(AuthorAttribute));

            // Check if the attribute exists and display its value
            if (authorAttribute != null)
            {
                Console.WriteLine($"Author of {classType.Name}: {authorAttribute.Name}");
            }
            else
            {
                Console.WriteLine("No Author attribute found.");
            }
        }
    }
}
