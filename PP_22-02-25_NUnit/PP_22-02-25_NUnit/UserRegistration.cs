using System.Text.RegularExpressions;
using System;

namespace PP_22_02_25_NUnit
{
    public class UserRegistration
    {
        public void RegisterUser(string username, string email, string password)
        {
            if (string.IsNullOrEmpty(username))
                throw new ArgumentException("Username cannot be null or empty.");

            if (string.IsNullOrEmpty(email) || !IsValidEmail(email))
                throw new ArgumentException("Invalid email address.");

            if (string.IsNullOrEmpty(password) || password.Length < 8)
                throw new ArgumentException("Password must be at least 8 characters long.");
        }

        private bool IsValidEmail(string email)
        {
            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return emailRegex.IsMatch(email);
        }
    }
}
