using Microsoft.EntityFrameworkCore;
using Sistema.Datos.Mapping.M_Almacen;
using Sistema.Datos.Mapping.M_Usuarios;
using Sistema.Datos.Mapping.M_Ventas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Datos_E.Mapping
{
    public class Db_Context_Sistema : DbContext
    {
        public DbContextSistema(DbContextOptions<DbContextSistema> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new Categoria_Map());

            modelBuilder.ApplyConfiguration(new Articulo_Map());

            modelBuilder.ApplyConfiguration(new Persona_Map());

            modelBuilder.ApplyConfiguration(new Rol_Map());

            modelBuilder.ApplyConfiguration(new Usuarios_Map());

            modelBuilder.ApplyConfiguration(new Detalle_Ingreso_Map());

            modelBuilder.ApplyConfiguration(new Detalle_Venta_Map());

            modelBuilder.ApplyConfiguration(new Ingreso_Map());

            modelBuilder.ApplyConfiguration(new Ventas_Map());



        }
    }
}