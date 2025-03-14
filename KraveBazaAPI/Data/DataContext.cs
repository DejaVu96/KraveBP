using KraveBazaAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace KraveBazaAPI.Data
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Krava> Krave { get; set; }
    }
}
