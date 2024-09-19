using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesControl.CreateClientRegistry.BusinessObject.PocoEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.DataContext.EntityFrameworkCore.Configuration
{
    internal class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(C => C.IdClient);
            builder.Property(C => C.DniClient)
                .HasMaxLength(8)
                .IsRequired();
            builder.Property(C => C.NameClient)
                .HasMaxLength(10)
                .IsRequired();
            builder.Property(C => C.SurnameClient)
                .HasMaxLength(10)
                .IsRequired();
            builder.Property(C => C.PhoneClient)
                .HasMaxLength(15)
                .IsRequired();
            builder.Property(C => C.EmailClient)
                .HasMaxLength(20)
                .IsRequired(false);
            builder.Property(C => C.Eliminado)
                .HasDefaultValue(false)
                .IsRequired();


        }
    }
}
