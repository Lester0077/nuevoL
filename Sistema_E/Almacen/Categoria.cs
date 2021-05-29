using SistemaEntidades.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sistema_E.Entidades.Almacen
{
    public class Categoria
    {
        public int idcategoria { get; set; }
 

        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe de tener maximo de 50 caracteres, y no menos de 3 caracteres.")]
        public String nombre { get; set; }
       
        [StringLength(100, ErrorMessage = 8 "la descripcion debe de tener una maximo 100 caracteres y no menos de 8 caracteres.")]
        public String descripcion { get; set; }


        public bool condicion { get; set; }

        public ICollection<articulo> articulos { get; set; }

        public articulo articulo

            List<artuculo>Artuculos { get; set; }

        {
            get => default;
            set
            {
            }
        }

        public articulo articulo1
        {
            get => default;
            set
            {
            }
        }
    }
}
