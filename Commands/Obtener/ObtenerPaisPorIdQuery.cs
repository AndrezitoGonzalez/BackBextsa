using MediatR;
using WebApplicationBextsa.Models;

namespace WebApplicationBextsa.Commands.Obtener
{
    public class ObtenerPaisPorIdQuery : IRequest<Pais>
    {
        public Guid id { get; set; }
    }
}
