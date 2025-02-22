using System.Linq;
using System;

namespace PP_22_02_25_NUnit
{
    public class PasswordValidator
    {
        public bool Validate(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Password cannot be null or empty.");

            bool hasUppercase = password.Any(char.IsUpper);
            bool hasDigit = password.Any(char.IsDigit);
            bool isLongEnough = password.Length >= 8;

            return hasUppercase && hasDigit && isLongEnough;
        }
    }
}
