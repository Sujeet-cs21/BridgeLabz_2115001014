using RepositoryLayer.Interface;
using BusinessLayer.Interface;
using ModelLayer.DTO;
using NLog;

namespace BusinessLayer.Service
{
    public class UserRegistrationBL : IUserRegistrationBL
    {
        private readonly IUserRegistrationRL _userRegistrationRL;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public UserRegistrationBL(IUserRegistrationRL userRegistrationRL)
        {
            _userRegistrationRL = userRegistrationRL;
        }

        public bool RegisterUserBL(RegistrationDTO newUser)
        {
            try
            {
                logger.Info($"Business Layer - Registering new user with Email : {newUser.email}");
                return _userRegistrationRL.RegisterUserRL(newUser);
            }
            catch (Exception e)
            {
                logger.Error(e, $"Business Layer - Error registering user: {newUser.email}");
                throw new Exception(e.Message);
                //return false;
            }
        }

        public List<RegistrationDTO> GetAllUsers()
        {
            try
            {
                logger.Info("Business Layer - Fetching all registered users.");
                return _userRegistrationRL.GetAllUsers();
            }
            catch (Exception e)
            {
                logger.Error(e, "Business Layer - Error fetching all users.");
                throw new Exception(e.Message);
                //return null;
            }
        }
    }
}
