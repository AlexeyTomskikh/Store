using System.Data.Entity;

namespace MainStore.Models.Repository
{
    public class EFDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}