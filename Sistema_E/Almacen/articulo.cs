using SistemaEntidades.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sistema_E.Entidades.Almacen
{
   public class articulo
    {
        public int idarticulo { get; set; }
        [Required]

        [StringLength(60, MinimumLength = 2, ErrorMessage = "El codigo articulo debe de tener maximo de 60 caracteres, y no menos de 2 caracteres.")]
        public String codigo_articilo { get; set; }

        [StringLength(60, MinimumLength = 5, ErrorMessage = "El nombre del articulo debe de tener maximo de 60 caracteres, y no menos de 5 caracteres.")]
        public String nombre_articulo { get; set; }

        
        public decimal venta_articulo { get; set; }

        public float stock_articulo { get; set; }

        [StringLength(256, ErrorMessage = 7 "la descripcion del articulo debe de tener una maximo 256 caracteres y no menos de 7 caracteres.")]
        public String descripcion_articulo { get; set; }

        public int condicion_articulo { get; set; }

        public int idmarca { get; set; }

        public ICollection<detalle_venta> detalle_ventas { get; set; }

        public ICollection<detalle_ingreso> detalle_Ingresos { get; set; }

        public venta venta
            //relacion con la tabla categoria
            public List<Categoria> Categorias { get; set; }
        {
            get => default;
            set
            {
            }
        }

        public venta venta1
        {
            get => default;
            set
            {
            }
        }
    }
}
