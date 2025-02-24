using System;
using System.Reflection;

namespace PP_24_02_25_Annotations
{
    //MaxLength attribute
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    class MaxLengthAttribute : Attribute
    {
        public int Length { get; }

        public MaxLengthAttribute(int length)
        {
            Length = length;
        }
    }

    //Applying the attribute to a class field (Username)
    class User
    {
        [MaxLength(10)]
        public string Username { get; }

        public User(string username)
        {
            ValidateMaxLength(this, nameof(Username), username);
            Username = username;
        }

        private void ValidateMaxLength(object obj, string propertyName, string value)
        {
            PropertyInfo property = obj.GetType().GetProperty(propertyName);
            var attribute = (MaxLengthAttribute)Attribute.GetCustomAttribute(property, typeof(MaxLengthAttribute));

            if (attribute != null && value.Length > attribute.Length)
            {
                throw new ArgumentException($"Error: {propertyName} cannot exceed {attribute.Length} characters.");
            }
        }
    }

    //Testing the validation
    class Class9
    {
        public static void Main9()
        {
            try
            {
                User user1 = new User("Asdfg");
                Console.WriteLine($"User created: {user1.Username}");

                User user2 = new User("Abcdefghijklm");
                Console.WriteLine($"User created: {user2.Username}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
