using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sistema_E.Entidades.Usuarios
{
   public class Usuarios
    {
        [Requiered]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El nombre debe de tener maximo de 30 caracteres, y no menos de 3 caracteres.")]
        public int idusuario { get; set; }

        [StringLength(100, ErrorMessage =5 "el nombre  su tamaño maximo es de 100 caracteres y no menos de 5 caracteres.")]
        public String nombre { get; set; }

        [StringLength(50, ErrorMessage = 5 "el tipo de documento  su tamaño maximo es de 50 caracteres y no menos de 5 caracteres.")]
        public String tipo_documento { get; set; }

        [StringLength(50, ErrorMessage = 5 "el numero de documento su tamaño maximo es de 50 caracteres y no menos de 5 caracteres.")]
        public String num_documento { get; set; }

        [StringLength(100, ErrorMessage = 5 "La direccion  su tamaño maximo es de 100 caracteres y no menos de 5 caracteres.")]
        public String direccion { get; set; }

        [StringLength(20, ErrorMessage = 6 "telefono  su tamaño maximo es de 20 caracteres y no menos de 6 caracteres.")]
        public String telefono { get; set; } //este va a cambiar

        [StringLength(20, ErrorMessage = "el Email debe de tener entre 6 y 20 caracteres", MinimumLength = 6)]
        [RegularExpression("^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$", ErrorMessage = "ingrese un Email valido")]
        public String email { get; set; }

        [StringLength(20, ErrorMessage = 8 "la contraseña hash debe de tener una maximo 20 caracteres y no menos de 8 caracteres.")]
        public String password_hash { get; set; }

        [StringLength(20, ErrorMessage = 8 "la contraseña sat debe de tener una maximo 20 caracteres y no menos de 8 caracteres.")]
        public String password_sat { get; set; }

        public bool condicion { get; set; }



    }
}
