using Microsoft.EntityFrameworkCore;
using PlakDukkani.Entities.Concrete;
using PlakDukkani.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani.DAL
{
    public class PlakDukkaniContext:DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Yonetici> Yoneticis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=PlakDukkaniDb;uid=sa;pwd=123; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlbumMapping());
            modelBuilder.ApplyConfiguration(new YoneticiMapping());
            base.OnModelCreating(modelBuilder);
        }

    }
}
