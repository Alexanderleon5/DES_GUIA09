using Microsoft.EntityFrameworkCore;

namespace LibroAPI.Models
{
    public class LibroContext : DbContext
    {
        public LibroContext(DbContextOptions<LibroContext> options) : base(options)
        {

        }

        public DbSet<Libro> LibroSet { get; set; }

    }
}
