using System;

namespace PP_21_02_25
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }

    class VotingEligibilty
    {
        static void ValidateAge(int age)
        {
            if (age < 18)
                throw new InvalidAgeException("Age must be 18 or above");

            Console.WriteLine("Access granted!");
        }

        public static void Main3()
        {
            try
            {
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                ValidateAge(age);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid age.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }

}
