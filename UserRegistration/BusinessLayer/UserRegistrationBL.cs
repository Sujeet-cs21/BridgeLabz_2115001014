using UserRegistration.RepositoryLayer;

namespace UserRegistration.BusinessLayer
{
    public class UserRegistrationBL
    {
        private readonly UserRegistrationRL _repositoryLayer;

        public UserRegistrationBL()
        {
            _repositoryLayer = new UserRegistrationRL();
        }

        public string RegistrationBL(string username, string password)
        {
            var (storedUsername, storedPassword) = _repositoryLayer.RegistrationRL();

            if (username == storedUsername && password == storedPassword)
            {
                return "Login Successful";
            }
            return "Invalid username and password";
        }
    }
}

