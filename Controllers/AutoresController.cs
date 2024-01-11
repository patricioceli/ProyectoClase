﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoClase.Models;
using ProyectoClase.Models.Entidades;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace ProyectoClase.Controllers
{
    public class AutoresController : Controller
    {
        private readonly LibreriaContext _context;

        public AutoresController(LibreriaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> ListadoAutores()
        {
            return View(await _context.Autores.ToListAsync());
        }

        public IActionResult Crear()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Crear(Autor autor)
        {

            if (ModelState.IsValid)
            {
                _context.Add(autor);
                await _context.SaveChangesAsync();
                TempData["AlertMessage"] = "Autor creado exitosamente";
                return RedirectToAction("ListadoAutores");

            }
            else
            {
                ModelState.AddModelError(String.Empty, "Ha ocurrido Un error");
            }



            return View();
        }


       
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null || _context.Autores == null)
            {
                return NotFound();
            }

            var autor = await _context.Autores.FindAsync(id);
            if (autor == null)
            {
                return NotFound();
            }
            return View(autor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // Agregar validación de token anti falsificación en la solicitud POST

        public async Task<IActionResult> Editar(int id, Autor autor)
        {
            if (id != autor.IdAutor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(autor);
                    await _context.SaveChangesAsync();
                    TempData["AlertMessage"] = "Autor actualizado " +
                        "exitosamente!!!";
                    return RedirectToAction("ListadoAutores");
                }
                catch (Exception ex)
                {

                    ModelState.AddModelError(ex.Message, "Ocurrio un error " +
                        "al actualizar");
                }
            }
            return View(autor);
        }

        public async Task<IActionResult> Eliminar(int? id)
        {
            if (id == null || _context.Autores == null)
            {
                return NotFound();
            }

            var autor = await _context.Autores
                .FirstOrDefaultAsync(m => m.IdAutor == id);

            if (autor == null)
            {
                return NotFound();
            }

            try
            {
                _context.Autores.Remove(autor);
                await _context.SaveChangesAsync();
                TempData["AlertMessage"] = "Autor eliminado exitosamente!!!";
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(ex.Message, "Ocurrio un error, no se pudo eliminar el registro");
            }

            return RedirectToAction(nameof(ListadoAutores));
        }

    }
}
