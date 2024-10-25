using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SalesControl.CreateClientRegistry.BusinessObject.PocoEntities;
using SalesControl.CreateClientRegistry.Entity;
using SalesControl.DataContext.EntityFrameworkCore.Options;
using System.Reflection;

namespace SalesControl.DataContext.EntityFrameworkCore.Context
{
    public class SalesControlContextProduction(IOptions<BDOptions> bdOptions) : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(bdOptions.Value.ConnectionString);
        }
        public DbSet<Client> clients { get; set; }
        public DbSet<Address> addresses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}