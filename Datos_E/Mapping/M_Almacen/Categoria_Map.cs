using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Entidades.M_Almacen;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Datos.Mapping.M_Almacen
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria")
                .HasKey(c => c.idcategoria);

            builder.Property(c => c.nombre)
                .HasMaxLength(50);

            builder.Property(c => c.descricion)
                .HasMaxLength(256);

            builder.Property(c => c.descricion)
                .HasMaxLength(50);
        }
    }
}
