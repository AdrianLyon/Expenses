using gastos.helpers.Models;
using Microsoft.EntityFrameworkCore;

namespace gastos.api.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }

        public DbSet<Expense> Expenses{get; set;}
        public DbSet<Category> Categories{get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Expense>().ToTable("Expense");
            modelBuilder.Entity<Category>().ToTable("Category");
        }
    }
}