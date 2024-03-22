using CarrielAPI.Model;
using CarrielAPI.Repository;
using CarrielAPI.Utilities;
using CarrielAPI.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarrielAPI.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository ?? throw new ArgumentNullException(nameof(usuarioRepository));
        }

        [HttpPost("cadastro")]
        public IActionResult AddUser(UsuarioRegisterViewModel usuarioView)
        {
            var existingUser = _usuarioRepository.GetExistUser(usuarioView.email);

            if (existingUser != null)
            {
                // Status HTTP 409
                return Conflict("Um usuário com o mesmo email já existe.");
            }
            DateTime adataAtual = DateTime.Now;
            string senhaHash = UsuarioUtilities.HashPassword(usuarioView.senha);

            var usuario = new Usuario(usuarioView.email, senhaHash, usuarioView.nome, adataAtual);

            _usuarioRepository.AddUser(usuario);

            // Status HTTP 200
            return Ok();
        }


        // [Authorize]
        [HttpPost("login")]
        public IActionResult GetUser(UsuarioLoginViewModel usuarioView)
        {

            if (usuarioView == null || string.IsNullOrEmpty(usuarioView.email) || string.IsNullOrEmpty(usuarioView.senha))
            {
                // Status HTTP 400
                return BadRequest("Email e senha são obrigatórios.");
            }

            string senhaHash = UsuarioUtilities.HashPassword(usuarioView.senha);
            var usuario = _usuarioRepository.GetUserByEmail(usuarioView.email, senhaHash);

            if (usuario == null)
            {
                // Status HTTP 404
                return NotFound("Usuário não encontrado ou senha incorreta.");
            }

            // Status HTTP 200
            return Ok(usuario);
        }
    }
}
