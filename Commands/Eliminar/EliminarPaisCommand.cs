using MediatR;

namespace WebApplicationBextsa.Commands.Eliminar
{
    public class EliminarPaisCommand : IRequest
    {
        public Guid id { get; set; }
    }
}
