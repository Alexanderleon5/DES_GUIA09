using System.ComponentModel.DataAnnotations;

namespace LibroAPI.Models
{
    public class Libro
    {

      
        public int Id { get; set; }
     
        public string Titulo { get; set; }

        public string? Auto { get; set; }


        public DateTime FechaPublicacion{ get; set; }
    }
}
