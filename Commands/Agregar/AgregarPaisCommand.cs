using MediatR;

namespace WebApplicationBextsa.Commands.Agregar
{
    public class AgregarPaisCommand : IRequest<Guid>
    {
        public string nombre { get; set; }
    }
}
