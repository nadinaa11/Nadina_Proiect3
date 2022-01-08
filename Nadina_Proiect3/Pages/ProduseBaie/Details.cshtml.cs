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

namespace Nadina_Proiect3.Pages.ProduseBaie
{
    public class DetailsModel : PageModel
    {
        private readonly Nadina_Proiect3.Data.Nadina_Proiect3Context _context;

        public DetailsModel(Nadina_Proiect3.Data.Nadina_Proiect3Context context)
        {
            _context = context;
        }

        public Baie Baie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Baie = await _context.Baie.FirstOrDefaultAsync(m => m.BaieId == id);

            if (Baie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
