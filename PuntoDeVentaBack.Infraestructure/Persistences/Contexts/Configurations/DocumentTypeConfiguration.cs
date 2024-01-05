using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PuntoDeVentaBack.Domain.Entities;
using System.Reflection.Emit;

namespace PuntoDeVentaBack.Infraestructure.Persistences.Contexts.Configurations
{
    public class DocumentTypeConfiguration : IEntityTypeConfiguration<DocumentType>
    {
        public void Configure(EntityTypeBuilder<DocumentType> builder)
        {

            builder.Property(e => e.Abbreviation)
                    .HasMaxLength(5)
                    .IsUnicode(false);

            builder.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

            builder.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
        }
    }
}
