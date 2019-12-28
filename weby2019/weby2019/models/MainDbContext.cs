using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace weby2019.models
{
    public class MainDbContext : DbContext
    {
        public DbSet<Slovo> Slova { get; set; }  
        public MainDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = slovicka; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 1, Name = "šiška", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 2, Name = "hřeben", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 3, Name = "sloupec", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 4, Name = "řádek", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 5, Name = "míč", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 6, Name = "pětka", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 7, Name = "okno", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 8, Name = "papír", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 9, Name = "stěna", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 10, Name = "kámen", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 11, Name = "nůž", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 12, Name = "houby", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 13, Name = "slovník", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 14, Name = "letadlo", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 15, Name = "světlo", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 16, Name = "housenka", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 17, Name = "koleno", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 18, Name = "slovo", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 19, Name = "požár", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 20, Name = "strom", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 21, Name = "voda", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 22, Name = "kočka", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 23, Name = "železo", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 24, Name = "kolo", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 25, Name = "platina", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 26, Name = "papoušek", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 27, Name = "skočit", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 28, Name = "houkat", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 29, Name = "růst", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 30, Name = "strop", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 31, Name = "vařit", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 32, Name = "ponožka", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 33, Name = "smrdí", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 34, Name = "házet", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 35, Name = "kopat", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 36, Name = "hotel", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 37, Name = "pole", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 38, Name = "užovka", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 39, Name = "hora", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 40, Name = "led", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 41, Name = "len", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 42, Name = "sen", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 43, Name = "ven", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 44, Name = "zem", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 45, Name = "hodiny", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 46, Name = "slimák", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 47, Name = "pes", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 48, Name = "hák", skore = 6 });
            modelBuilder.Entity<Slovo>().HasData(new Slovo { Id = 49, Name = "mák", skore = 6 });
        }

    }
}
