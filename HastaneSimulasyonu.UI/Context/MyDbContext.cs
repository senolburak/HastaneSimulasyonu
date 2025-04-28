using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneSimulasyonu.UI.Models;
using Microsoft.EntityFrameworkCore;

namespace HastaneSimulasyonu.UI.Context
{
    public class MyDbContext : DbContext
    {
        public DbSet<Bolum> Bolum { get; set; }
        public DbSet<Doktor> Doktor { get; set; }
        public DbSet<Hasta> Hasta { get; set; }
        public DbSet<Randevu> Randevu { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BURAKSENOL\\SQLEXPRESS;Database=HastaneDb;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
