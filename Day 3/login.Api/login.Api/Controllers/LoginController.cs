using Microsoft.AspNetCore.Mvc;
using MissionEntities.Entities;
using MissionServices.InterfaceServices;

namespace login.Api.Controllers
{
    [ApiController]
        [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost]
        [Route("login")]
        public IActionResult Login(string EmailAddress, string Password)
        {
            var user = _loginService.login(EmailAddress, Password);
            if (user == null)
            {
                return NotFound(new {message = "Invalid Credentials" });
            }
            return Ok(new {message = "Login Successfull"});
        }

        [HttpPost]
        [Route("register")]
        public IActionResult register([FromBody] User user)
        {
            var createdUser = _loginService.register(user);
            if (createdUser == null)
            {
                return BadRequest(new { message = "User already exists" });

            }
            return Ok(new { message = "Registration successful" });

        }
    }
}
