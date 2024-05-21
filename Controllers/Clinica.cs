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
    public class ClinicaController : ControllerBase
    {
        private readonly MyDbContext _context;

        public ClinicaController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Clinica>> GetClinicas()
        {
            return _context.Clinicas.ToList();
        }

        [HttpPost]
        public async Task<ActionResult<Clinica>> PostClinica(Clinica clinica)
        {
            _context.Clinicas.Add(clinica);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetClinicas), new { id = clinica.Id }, clinica);
        }
    }
}
