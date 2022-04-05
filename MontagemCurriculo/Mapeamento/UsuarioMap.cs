﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MontagemCurriculo.Models;

namespace MontagemCurriculo.Mapeamento
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        void IEntityTypeConfiguration<Usuario>.Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.UsuarioId);

            builder.Property(u => u.Email).IsRequired().HasMaxLength(50);
            builder.HasIndex(u => u.Email).IsUnique();

            builder.Property(u=>u.Senha).IsRequired().HasMaxLength(50);


            builder.HasMany(u=>u.Curriculos).WithOne(u=>u.Usuario).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(u => u.InformacoesLogin).WithOne(u => u.Usuario).OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Usuarios");
        }
    }
}
