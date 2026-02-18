using Api.Models;
namespace Api.Services;
public interface ITareaService
{
    List<Tarea> ObtenerTodas();
    void Agregar(Tarea tarea);
}