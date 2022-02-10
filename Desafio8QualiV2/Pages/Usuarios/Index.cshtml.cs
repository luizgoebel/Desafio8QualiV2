using Desafio8QualiV2.Data;
using Desafio8QualiV2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio8QualiV2.Pages.Usuarios
{
    public class IndexModel : PageModel
    {
        private readonly WebContext _context;

        public IndexModel(WebContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Usuario Usuario { get; set; }

        [BindProperty]
        public int IdUsuario { get; set; }

        public List<Usuario> Usuarios { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            await Carregamento();
            return Page();
        }

        public async Task<IActionResult> OnPostCadastrarAsync()
        {
            await Carregamento();
            if (ModelState.IsValid)
            {
                try
                {
                    Usuario.Create = DateTime.Now;
                    Usuario.Change = DateTime.Now;
                    await _context.AddAsync(Usuario);
                    await _context.SaveChangesAsync();
                    return RedirectToPage("../Usuarios/Index");
                }
                catch (Exception)
                {
                    if (!UsuarioExiste(Usuario.Id))
                    {
                        return NotFound();
                    }
                }
            }
            return Page();
        }

        public async Task<IActionResult> OnPostDeletarAsync()
        {
            Usuario usuario = await _context.Usuarios.FirstOrDefaultAsync(c => c.Id == IdUsuario);
            try
            {
                if (UsuarioExiste(usuario.Id))
                {
                    _context.Remove(usuario);
                    await _context.SaveChangesAsync();
                    return RedirectToPage("../Usuarios/Index");
                }
            }
            catch (Exception)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostEditarAsync()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Usuario.Change = DateTime.Now;
                    _context.Usuarios.Update(Usuario);
                    await _context.SaveChangesAsync();
                    return RedirectToPage("../Usuarios/Index");
                }
                catch (Exception)
                {
                    return NotFound();
                }
            }

            return Page();
        }

        private bool UsuarioExiste(int id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }

        private async Task Carregamento()
        {
            Usuarios = await _context.Usuarios.ToListAsync();
        }
    }
}
