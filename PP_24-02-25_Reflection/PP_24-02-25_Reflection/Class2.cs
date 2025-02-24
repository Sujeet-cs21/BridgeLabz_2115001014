using System;
using System.Reflection;

namespace PP_24_02_25_Reflection
{
    class Person
    {
        private int age;

        public Person(int initialAge)
        {
            age = initialAge;
        }

        public void DisplayAge()
        {
            Console.WriteLine($"Age: {age}");
        }
    }

    class Class2
    {
        public static void Main2()
        {
            Person person = new Person(25);

            Console.WriteLine("Before using Reflection:");
            person.DisplayAge();

            // Using Reflection to access age
            Type personType = typeof(Person);
            FieldInfo ageField = personType.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

            // Modifing the private field value
            ageField.SetValue(person, 30);

            Console.WriteLine("\nAfter using Reflection to modify 'age':");
            person.DisplayAge();

            //the modified value of the private field
            int modifiedAge = (int)ageField.GetValue(person);
            Console.WriteLine($"Modified age : {modifiedAge}");
        }
    }
}
