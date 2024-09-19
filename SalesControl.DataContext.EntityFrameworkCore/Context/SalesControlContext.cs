using Microsoft.EntityFrameworkCore;
using SalesControl.CreateClientRegistry.BusinessObject.Aggregate;
using SalesControl.CreateClientRegistry.BusinessObject.PocoEntities;
using SalesControl.DataContext.EntityFrameworkCore.PocoEntities;
using System.Reflection;

namespace SalesControl.DataContext.EntityFrameworkCore.Context
{
    public class SalesControlContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdB)\\mssqllocaldB; DataBase = SalesControl");
        }
        public DbSet<Client> clients { get; set; }
        public DbSet<PocoAddress> pocoAddresses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
