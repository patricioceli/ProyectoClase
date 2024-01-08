using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProyectoClase.Services
{
    public interface IServicioLista
    {
        Task<IEnumerable<SelectListItem>> 
            GetListaAutores();
        Task<IEnumerable<SelectListItem>> 
            GetListaCategorias();
    }
}
