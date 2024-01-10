using MediatR;
using WebApplicationBextsa.Models;

namespace WebApplicationBextsa.Commands.Eliminar
{
    public class EliminarPaisCommandHandler : IRequestHandler<EliminarPaisCommand>
    {
        private readonly ApplicationDbContext _context;

        public EliminarPaisCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(EliminarPaisCommand request, CancellationToken cancellationToken)
        {
            var pais = await _context.Paises.FindAsync(request.id);

            if (pais == null)
            {
                // Manejar el caso en el que el país no se encuentra
                //throw new NotFoundException(nameof(Pais), request.Id);
            }

            _context.Paises.Remove(pais);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
