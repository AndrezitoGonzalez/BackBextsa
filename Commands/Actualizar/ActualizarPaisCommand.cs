using MediatR;

namespace WebApplicationBextsa.Commands.Actualizar
{
    public class ActualizarPaisCommand : IRequest
    {
        public Guid id { get; set; }
        public string nombre { get; set; }
    }
}
