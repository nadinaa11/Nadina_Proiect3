#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nadina_Proiect3.Data;
using Nadina_Proiect3.Models;

namespace Nadina_Proiect3.Pages.ProduseLiving
{
    public class EditModel : PageModel
    {
        private readonly Nadina_Proiect3.Data.Nadina_Proiect3Context _context;

        public EditModel(Nadina_Proiect3.Data.Nadina_Proiect3Context context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Living).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LivingExists(Living.LivingId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool LivingExists(int id)
        {
            return _context.Living.Any(e => e.LivingId == id);
        }
    }
}
