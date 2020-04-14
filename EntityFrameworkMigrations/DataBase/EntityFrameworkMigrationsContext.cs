using EntityFrameworkMigrations.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkMigrations.DataBase
{
    public class EntityFrameworkMigrationsContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=teste;user=root;password=aff123");            
        }
    }
}
