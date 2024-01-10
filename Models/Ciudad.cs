using System.ComponentModel.DataAnnotations;

namespace WebApplicationBextsa.Models
{
    public class Ciudad
    {
        [Key]
        public int id { get; set; }
        public string? Nombre { get; set; }
    }
}
