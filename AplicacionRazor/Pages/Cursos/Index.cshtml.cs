using AplicacionRazor.modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace AplicacionRazor.Pages.Cursos
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _contexto;

        public IndexModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;   
        }

        [TempData]
        public string Mensaje { get; set; }

        public IEnumerable <Curso> Cursos { get; set; }

        public async Task OnGet()
        {
            Cursos = await _contexto.Curso.ToListAsync();
        }

        public async Task<IActionResult> OnPostBorrar(int Id)
        {
                var Curso = await _contexto.Curso.FindAsync(Id);
                if(Curso == null)
                {
                    return NotFound();
                }

                _contexto.Curso.Remove(Curso);
                await _contexto.SaveChangesAsync();
                Mensaje = "Curso Borrado";
               return RedirectToPage("Index");
        }
    }
}
