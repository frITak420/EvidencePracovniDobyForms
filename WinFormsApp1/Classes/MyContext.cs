using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class MyContext : DbContext
    {
        public DbSet<Projekt> Projekty { get; set; }
        public DbSet<Uzivatel> Uzivatele { get; set; }
        public DbSet<Zakaznik> Zakaznici { get; set; }
        public DbSet<Cinnost> Cinnosti { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
               //optionsBuilder.UseMySQL("server=;database=;user=;password=;SslMode=none");  your db here
        }
    }
}
