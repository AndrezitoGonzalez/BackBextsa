using MediatR;
using WebApplicationBextsa.Models;

namespace WebApplicationBextsa.Commands.Agregar
{
    public class AgregarPaisCommandHandler : IRequestHandler<AgregarPaisCommand, Guid>
    {
        private readonly ApplicationDbContext _context;

        public AgregarPaisCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(AgregarPaisCommand request, CancellationToken cancellationToken)
        {
            var nuevoPais = new Pais { id = Guid.NewGuid(), nombre = request.nombre };
            _context.Paises.Add(nuevoPais);
            await _context.SaveChangesAsync();
            return nuevoPais.id;
        }
    }
}
