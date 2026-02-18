using Microsoft.AspNetCore.Mvc;
using Api.Models;
using Api.Services;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TareasController : ControllerBase
{
    private readonly ITareaService _service;
    public TareasController(ITareaService service)
    {
        _service = service;
    }

    [HttpGet]
    public ActionResult<List<Tarea>> Get() => Ok(_service.ObtenerTodas());

    [HttpPost]
    public IActionResult Post(Tarea nuevaTarea)
    {
        _service.Agregar(nuevaTarea);
        return CreatedAtAction(nameof(Get), nuevaTarea);
    }
}