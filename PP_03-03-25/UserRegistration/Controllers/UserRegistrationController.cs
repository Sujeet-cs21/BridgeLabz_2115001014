using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Interface;
using ModelLayer.DTO;
using NLog;

namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        private readonly IUserRegistrationBL _userRegistrationBL;
        ResponseModel<RegistrationDTO> response;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public UserRegistrationController(IUserRegistrationBL userRegistrationBL)
        {
            _userRegistrationBL = userRegistrationBL;
        }

        [HttpGet]
        public string Get()
        {
            return "Welcome to User Registration Portal!";
        }

        // API to register a user
        [HttpPost("register")]
        public IActionResult RegisterUser([FromBody] RegistrationDTO newUser)
        {
            try
            {
                logger.Info($"API initiated to register new user with email: {newUser.email}");
                response = new ResponseModel<RegistrationDTO>();

                if (newUser == null)
                {
                    logger.Warn("Invalid user data received for registration.");
                    return BadRequest(new { Success = false, Message = "Invalid user data" });
                }

                bool isRegistered = _userRegistrationBL.RegisterUserBL(newUser);
                if (isRegistered)
                {
                    logger.Info($"User registered successfully! with email: {newUser.email}");
                    response.Success = true;
                    response.Message = $"User registered successfully! with email: {newUser.email}";
                    response.Data = newUser;
                    return Ok(response);
                }
                logger.Warn("User registration failed!");
                response.Success = false;
                response.Message = "User registration failed!";
                return BadRequest();
            }
            catch (Exception e)
            {
                logger.Error(e, $"Error registering user: {newUser.email}");
                response.Success = false;
                response.Message = e.Message;
                return BadRequest(response);
            }
        }

        // API to get all registered users
        [HttpGet("users")]
        public IActionResult GetUsers()
        {
            try
            {
               

                logger.Info("API initiated to fetch all registered users.");
                var response = new ResponseModel<List<RegistrationDTO>>();
                var users = _userRegistrationBL.GetAllUsers();

                response.Success = true;
                response.Message = "User list fetched successfully!";
                response.Data = users;

                return Ok(response);
            }
            catch (Exception e)
            {
                logger.Error(e, "Error fetching all users.");
                response.Success = false;
                response.Message = e.Message;
                return BadRequest(response);
            }
        }
    }
}
