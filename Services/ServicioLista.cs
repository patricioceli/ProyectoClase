using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoClase.Models;

namespace ProyectoClase.Services
{
    public class ServicioLista : IServicioLista
    {
        private readonly LibreriaContext _context;

        public ServicioLista(LibreriaContext context) {

            _context = context;
        }

        public async Task<IEnumerable<SelectListItem>> GetListaAutores()
        {
            List<SelectListItem> list = await _context.Autores.Select(x => new SelectListItem
            {
                Text = x.Nombre,
                Value = $"{x.IdAutor}"
            })
                 .OrderBy(x => x.Text)
                 .ToListAsync();

            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un autor...]",
                Value = "0"
            });
            
            return list;
        }

        public async Task<IEnumerable<SelectListItem>> GetListaCategorias()
        {
            List<SelectListItem> list = await _context.Categorias.Select(x => new SelectListItem
            {
                Text = x.Nombre,
                Value = $"{x.IdCategoria}"
            })
               .OrderBy(x => x.Text)
               .ToListAsync();
            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione una categoría...]",
                Value = "0"
            });
            return list;
        }


    }
}
