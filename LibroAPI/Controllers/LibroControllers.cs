using Microsoft.AspNetCore.Mvc;
using LibroAPI.Models;


namespace LibrosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private readonly LibroContext _context;

        public LibrosController(LibroContext context)
        {
            _context = context;
        }

        [HttpPost]

        public async Task<ActionResult<Libro>> PostLibro(Libro libro)
        {
            if (string.IsNullOrEmpty(libro.Titulo))
            {
                return BadRequest("el título no puede estar vací");
            }
            _context.LibroSet.Add(libro);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetLibro), new { id = libro.Id }, libro);

        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Libro>> GetLibro(int id)
        {
            var libro = await _context.LibroSet.FindAsync(id);
            if (libro == null)
            {
                return NotFound();
            }
            return libro;
        }
    }
}
