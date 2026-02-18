using Api.Models;
namespace Api.Services;
public class TareaService : ITareaService
{
    private readonly List<Tarea>_tareas = new()
    {
      new Tarea { Id = 1, Titulo = "Mi primera API profesional", EstaCompletada = false}  
    };
    public List<Tarea> ObtenerTodas() => _tareas;
    public void Agregar(Tarea tarea)
    {
        tarea.Id = _tareas.Count + 1;
        _tareas.Add(tarea);
    }
}