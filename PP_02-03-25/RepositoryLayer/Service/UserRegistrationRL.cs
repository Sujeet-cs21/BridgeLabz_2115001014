using ModelLayer.DTO;
using RepositoryLayer.Interface;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using NLog;

namespace RepositoryLayer.Service
{
    public class UserRegistrationRL : IUserRegistrationRL
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly UserRegistrationContext _context;
        public UserRegistrationRL(UserRegistrationContext context)
        {
            _context = context;
        }
        public bool RegisterUserRL(RegistrationDTO newUser)
        {
            try
            {
                if (newUser == null || string.IsNullOrEmpty(newUser.email) || string.IsNullOrEmpty(newUser.password))
                {
                    logger.Warn("Invalid user data received for registration.");
                    return false;
                }

                var userEntity = new UserEntity
                {
                    Email = newUser.email,
                    FirstName = newUser.firstname,
                    LastName = newUser.lastname,
                    Password = newUser.password
                };
                // Add the new user to the database
                _context.Users.Add(userEntity);
                _context.SaveChanges();

                logger.Info($"User registered successfully! with email: {newUser.email}");

                return true;
            }
            catch (Exception e)
            {

                logger.Error(e, "Error in Repository Layer while registering user: {0}", newUser.email);
                throw new Exception(e.Message);
                //return false;
            }
        }

        public List<RegistrationDTO> GetAllUsers()
        {
            try
            {
                logger.Info("Fetching all registered users from the database.");
                var _users= _context.Users.Select(user => new RegistrationDTO
                {
                    email = user.Email,
                    firstname = user.FirstName,
                    lastname = user.LastName,
                    password = user.Password
                }).ToList();
                return _users;
            }
            catch (Exception e)
            {
                logger.Error(e, "Error in Repository Layer while fetching all users.");
                throw new Exception(e.Message);
                //return null;
            }
        }
    }
}