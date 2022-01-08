#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Nadina_Proiect3.Data;
using Nadina_Proiect3.Models;

namespace Nadina_Proiect3.Pages.ProduseLiving
{
    public class DeleteModel : PageModel
    {
        private readonly Nadina_Proiect3.Data.Nadina_Proiect3Context _context;

        public DeleteModel(Nadina_Proiect3.Data.Nadina_Proiect3Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Living Living { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Living = await _context.Living.FirstOrDefaultAsync(m => m.LivingId == id);

            if (Living == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Living = await _context.Living.FindAsync(id);

            if (Living != null)
            {
                _context.Living.Remove(Living);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
