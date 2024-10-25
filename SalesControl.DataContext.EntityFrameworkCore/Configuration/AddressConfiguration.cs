using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesControl.CreateClientRegistry.BusinessObject.Aggregate;
using SalesControl.CreateClientRegistry.BusinessObject.PocoEntities;
using SalesControl.CreateClientRegistry.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.DataContext.EntityFrameworkCore.Configuration
{
    internal class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.IdAddress);
            builder.Property(a => a.IdClient)
                .IsRequired();
            builder.Property(a => a.Street)
                .IsRequired();
            builder.Property(a => a.District)
                .IsRequired();
            builder.Property(a => a.Departament)
                .IsRequired();   
            builder.Property(a => a.Province)
                .IsRequired();
            builder.Property(a => a.PostalCode)
                .IsRequired();
            builder.Property(a => a.Delete)
                .HasDefaultValue(false)
                .IsRequired();

            builder.HasOne<Client>()
                .WithOne()
                .HasForeignKey<Address>(a => a.IdClient);
        }
    }
}
