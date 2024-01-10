using MediatR;
using WebApplicationBextsa.Models;

namespace WebApplicationBextsa.Commands.Actualizar
{
    public class ActualizarPaisCommandHandler : IRequestHandler<ActualizarPaisCommand>
    {
        private readonly ApplicationDbContext _context;

        public ActualizarPaisCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(ActualizarPaisCommand request, CancellationToken cancellationToken)
        {
            var pais = await _context.Paises.FindAsync(request.id);

            if (pais == null)
            {
                // Manejar el caso en el que el país no se encuentra
                //throw new NotFoundException(nameof(Pais), request.id);
            }

            // Actualizar las propiedades necesarias
            pais.nombre = request.nombre;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
