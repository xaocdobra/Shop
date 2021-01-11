using Microsoft.EntityFrameworkCore;

namespace Shop.Data
{
    public class ItemsDbContext : DbContext
    {

        public DbSet<Item> Items { get; set; }

        private readonly string _connectionString = "asdasd";

        public ItemsDbContext(DbContextOptions<ItemsDbContext> options)
            : base(options)
        {
        }

   

        public ItemsDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
