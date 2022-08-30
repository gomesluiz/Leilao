using Microsoft.EntityFrameworkCore;

using Web.Models;

namespace Web.Persistence.Repositories
{
    public class LeilaoContext : DbContext
    {
        private string database;
        public DbSet<Leilao> Leiloes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public LeilaoContext(string database)
        {
            this.database = database;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={database}");
            base.OnConfiguring(optionsBuilder);
        }
    }
}

