using MediatR;
using WebApplicationBextsa.Models;

namespace WebApplicationBextsa.Commands.Obtener
{
    public class ObtenerPaisPorIdQueryHandler : IRequestHandler<ObtenerPaisPorIdQuery, Pais>
    {
        private readonly ApplicationDbContext _context;

        public ObtenerPaisPorIdQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Pais> Handle(ObtenerPaisPorIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Paises.FindAsync(request.id);
        }
    }
}
