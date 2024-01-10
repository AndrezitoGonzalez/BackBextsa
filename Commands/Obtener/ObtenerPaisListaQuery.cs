using MediatR;
using WebApplicationBextsa.Models;

namespace WebApplicationBextsa.Commands.Obtener
{
    public class ObtenerPaisListaQuery : IRequest<List<Pais>>
    {
    }
}
