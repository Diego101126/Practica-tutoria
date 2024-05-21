using Microsoft.AspNetCore.Mvc;
using practica_tutoria.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practica_tutoria.Entidades;

namespace TuProyecto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly MyDbContext _context;

        public UsuarioController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> GetUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUsuarios), new { id = usuario.Id }, usuario);
        }
    }
}
