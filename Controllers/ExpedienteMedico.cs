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
    public class ExpedienteMedicoController : ControllerBase
    {
        private readonly MyDbContext _context;

        public ExpedienteMedicoController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ExpedienteMedico>> GetExpedientesMedicos()
        {
            return _context.ExpedientesMedicos.ToList();
        }

        [HttpPost]
        public async Task<ActionResult<ExpedienteMedico>> PostExpedienteMedico(ExpedienteMedico expedienteMedico)
        {
            _context.ExpedientesMedicos.Add(expedienteMedico);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetExpedientesMedicos), new { id = expedienteMedico.Id }, expedienteMedico);
        }
    }
}
