#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nadina_Proiect3.Models;

namespace Nadina_Proiect3.Data
{
    public class Nadina_Proiect3Context : DbContext
    {
        public Nadina_Proiect3Context (DbContextOptions<Nadina_Proiect3Context> options)
            : base(options)
        {
        }

        public DbSet<Nadina_Proiect3.Models.Produs> Produs { get; set; }

        public DbSet<Nadina_Proiect3.Models.Categorie> Categorie { get; set; }

        public DbSet<Nadina_Proiect3.Models.Dormitor> Dormitor { get; set; }

        public DbSet<Nadina_Proiect3.Models.Living> Living { get; set; }

        public DbSet<Nadina_Proiect3.Models.Baie> Baie { get; set; }

        public DbSet<Nadina_Proiect3.Models.Exterior> Exterior { get; set; }
    }
}
