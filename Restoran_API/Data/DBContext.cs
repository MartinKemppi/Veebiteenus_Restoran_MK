using Restoran_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Restoran_API.Data
{
    public class DBContext : DbContext
    {
        public DbSet<Arve> Arved { get; set; }        
        public DbSet<Kasutaja> Kasutajad { get; set; }
        public DbSet<Restoran> Restoranid { get; set; }
        public DbSet<Tellimus> Tellimused { get; set; }
        public DbSet<Toode> Tooded { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }
    }
}
