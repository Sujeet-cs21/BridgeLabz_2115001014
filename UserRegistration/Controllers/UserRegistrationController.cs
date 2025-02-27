using Microsoft.AspNetCore.Mvc;
using UserRegistration.BusinessLayer;

namespace UserRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRegistrationController : ControllerBase
    {
        private readonly UserRegistrationBL _businessLayer;

        public UserRegistrationController()
        {
            _businessLayer = new UserRegistrationBL();
        }

        [HttpPost("register")]
        public IActionResult Registration()
        {
            string username = "root";
            string password = "root";

            string response = _businessLayer.RegistrationBL(username, password);

            return Ok(response);
        }
    }
}
