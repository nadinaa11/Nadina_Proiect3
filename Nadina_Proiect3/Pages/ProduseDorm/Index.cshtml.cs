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

namespace Nadina_Proiect3.Pages.ProduseDorm
{
    public class IndexModel : PageModel
    {
        private readonly Nadina_Proiect3.Data.Nadina_Proiect3Context _context;

        public IndexModel(Nadina_Proiect3.Data.Nadina_Proiect3Context context)
        {
            _context = context;
        }

        public IList<Dormitor> Dormitor { get;set; }

        public async Task OnGetAsync()
        {
            Dormitor = await _context.Dormitor.ToListAsync();
        }
    }
}
