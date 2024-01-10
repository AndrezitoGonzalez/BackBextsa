using System.ComponentModel.DataAnnotations;

namespace WebApplicationBextsa.Models
{
    public class Pais
    {
        [Key]
        public Guid id { get; set; }
        public string? nombre { get; set; }
    }
}
