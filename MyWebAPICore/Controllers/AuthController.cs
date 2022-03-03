using Microsoft.AspNetCore.Mvc;
using MyWebAPICore.Dtos;
using MyWebAPICore.Models;
using MyWebAPICore.Services.AuthService;

namespace MyWebAPICore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginDto request)
        {
            var response = await _authService.Login(request.Username, request.Password);

            if(response.Data == null)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            return Ok(_authService.Logout());
        }
    }
}
