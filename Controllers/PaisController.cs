using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplicationBextsa.Commands.Actualizar;
using WebApplicationBextsa.Commands.Agregar;
using WebApplicationBextsa.Commands.Eliminar;
using WebApplicationBextsa.Commands.Obtener;
using WebApplicationBextsa.Models;

[ApiController]
[Route("api/[controller]")]
public class PaisController : ControllerBase
{
    private readonly IMediator _mediator;

    public PaisController(IMediator mediator)
    {
        _mediator = mediator;
    }


    [HttpGet("createPais")]
    public async Task<IActionResult> createPais(string nombre)
    {
        AgregarPaisCommand objetoPais = new AgregarPaisCommand();
        objetoPais.nombre = nombre;
        var paisId = await _mediator.Send(objetoPais);
        return CreatedAtAction(nameof(ObtenerPaisPorId), new { id = paisId }, null);
    }


    [HttpGet("eliminarPais")]
    public async Task<IActionResult> EliminarPais(Guid id)
    {
        var command = new EliminarPaisCommand { id = id };
        await _mediator.Send(command);

        return NoContent();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Pais>> ObtenerPaisPorId(Guid id)
    {

        var query = new ObtenerPaisPorIdQuery { id = id };
        var result = await _mediator.Send(query);

        if (result == null)
        {
            return NotFound();
        }

        return Ok(result);
    }

    [HttpGet("ObtenerPaisLista")]
    public async Task<ActionResult<Pais>> ObtenerPaisLista()
    {

        var query = new ObtenerPaisListaQuery {};
        var result = await _mediator.Send(query);

        if (result == null)
        {
            return NotFound();
        }

        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> ActualizarPais([FromBody] ActualizarPaisCommand command)
    {
        //if (id != command.id)
        //{
        //    return BadRequest();
        //}

        await _mediator.Send(command);

        return NoContent();
    }

    
}
