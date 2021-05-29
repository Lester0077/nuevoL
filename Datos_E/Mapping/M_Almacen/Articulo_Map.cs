using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Entidades.M_Almacen;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Datos.Mapping.M_Almacen
{
   public class Articulo_Map : IEntityTypeConfiguration<articulo>
    {
        public void Configure(EntityTypeBuilder<articulo> builder)
        {
            builder.ToTable("Articulo")
                .HasKey(c => c.idarticulo);

            builder.Property(c => c.codigo_articilo)
                .HasMaxLength(50);

            builder.Property(c => c.nombre_articulo)
                .HasMaxLength(50);

            builder.Property(c => c.venta_articulo)
                .HasMaxLength(11);

            builder.Property(c => c.stock_articulo)
                .HasMaxLength(50);

            builder.Property(c => c.descripcion_articulo)
                .HasMaxLength(256);

            builder.Property(c => c.condicion_articulo)
                .HasMaxLength(10);

            builder.Property(c => c.idmarca)
                .HasMaxLength(100);
        }
    }
}
