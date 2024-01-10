using MediatR;
using Microsoft.EntityFrameworkCore;
using WebApplicationBextsa.Models;

namespace WebApplicationBextsa.Commands.Obtener
{
    public class ObtenerPaisListaQueryHandler : IRequestHandler<ObtenerPaisListaQuery, List<Pais>>
    {
        private readonly ApplicationDbContext _context;

        public ObtenerPaisListaQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Pais>> Handle(ObtenerPaisListaQuery request, CancellationToken cancellationToken)
        {
            // Utiliza un método adecuado para obtener la lista de países, por ejemplo, ToListAsync()
            return await _context.Paises.ToListAsync();
        }
    }
}
