﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PuntoDeVentaBack.Domain.Entities;

namespace PuntoDeVentaBack.Infraestructure.Persistences.Contexts.Configurations
{
    public class MenuRoleConfiguration : IEntityTypeConfiguration<MenuRole>
    {
        public void Configure(EntityTypeBuilder<MenuRole> builder)
        {


            builder.HasKey(e => e.MenuRolId)
                    .HasName("PK__MenuRole__6640AD0C1B045C7E");

            builder.HasOne(d => d.Menu)
                    .WithMany(p => p.MenuRoles)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_MenuRoles_Menu");

            builder.HasOne(d => d.Role)
                    .WithMany(p => p.MenuRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_MenuRoles_Roles");

        }
    }
}
