using Microsoft.EntityFrameworkCore;
using SalesControl.CreateClientRegistry.BusinessObject.PocoEntities;
using SalesControl.CreateClientRegistry.Entity;
using System.Reflection;

namespace SalesControl.DataContext.EntityFrameworkCore.Context
{
    public class SalesControlContext() : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; DataBase = SalesControl");
        }
        public DbSet<Client> clients { get; set; }
        public DbSet<Address> addresses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
