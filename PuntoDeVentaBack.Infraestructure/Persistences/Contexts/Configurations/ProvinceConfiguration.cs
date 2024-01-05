﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PuntoDeVentaBack.Domain.Entities;
using System.Reflection.Emit;

namespace PuntoDeVentaBack.Infraestructure.Persistences.Contexts.Configurations
{
    public class ProvinceConfiguration : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {

            builder.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

            builder.HasOne(d => d.Department)
                    .WithMany(p => p.Provinces)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Provinces__Depar__656C112C");
        }
    }
}
