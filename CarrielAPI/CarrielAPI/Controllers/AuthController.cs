using CarrielAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarrielAPI.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(string email, string senha)
        {
            if (string.IsNullOrEmpty(email))
            {
                var token = TokenService.GenerateToken(new Model.Usuario());
                return Ok(token);
            }

            return BadRequest("username or password invalid");
        }
    }
}
