using System.ComponentModel.DataAnnotations;
namespace WebApplicationBextsa.Models
{
    public class Departamento
    {
        [Key]
        public Guid id { get; set; }
        public string? Nombre { get; set; }
    }
}
