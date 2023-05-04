using ControleTarefas.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleTarefas.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {

        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> GetUsuarios()

        {
            var usuario1 = new Usuario();
            usuario1.UsuarioId = 1;
            usuario1.Login = "Ciclano";
            usuario1.Senha = "mudarSenha";

            var usuario2 = new Usuario
            {
                UsuarioId = 2,
                Login = "Fulano",
                Senha = "Teste123"
            };

            var usuarios = new List<Usuario>();
            usuarios.Add(usuario1);
            usuarios.Add(usuario2);

            return Ok(usuarios);
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuarioById(int id)

        {
            var usuario1 = new Usuario();
            usuario1.UsuarioId = 1;
            usuario1.Login = "Yasnaya";
            usuario1.Senha = "mudarSenha";

            var usuario2 = new Usuario
            {
                UsuarioId = 2,
                Login = "Fulano",
                Senha = "Teste123"
            };

            var usuarios = new List<Usuario>();
            usuarios.Add(usuario1);
            usuarios.Add(usuario2);

            var usuarioSelecionado = usuarios.FirstOrDefault(x => x.UsuarioId == id);

            return Ok(usuarioSelecionado);

        }
        [HttpPost]

        public async Task<ActionResult<Usuario>> Cadastrar([FromBody] Usuario usuario)
        {

            usuario.Login = usuario.Login + "OK";
            return Ok(usuario);
    }
  }
}


