using Sistema_E.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sistema_E.Entidades.Usuarios
{
    public class persona
    {
        public int idpersona { get; set; }
       

        public int tipo_persona { get; set; }
       
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El nombre debe de tener maximo de 30 caracteres, y no menos de 3 caracteres.")]
        public String nombre { get; set; }

        [StringLength(20, ErrorMessage = 8 "la contraseña debe de tener una maximo 20 caracteres y no menos de 8 caracteres.")]
        public String tipo_documento { get; set; }

        [StringLength(40, ErrorMessage = 2 "el numero de documento debe de tener una maximo 40 caracteres y no menos de 2 caracteres.")]
        public String num_documento { get; set; }

        [StringLength(20, ErrorMessage = 8 "la contraseña debe de tener una maximo 20 caracteres y no menos de 8 caracteres.")]
        public String direccion { get; set; }

        [StringLength(20, ErrorMessage = 6 "el telefono debe de tener una maximo 20 caracteres y no menos de 6 caracteres.")]
        public String telefono { get; set; } // este debe de cambiar

        [StringLength(16, ErrorMessage = "el Email debe de tener entre 5 y 16 caracteres", MinimumLength = 5)]
        [RegularExpression("^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$", ErrorMessage = "ingrese un Email valido")]
        public String email { get; set; }

        public ICollection<ingreso> ingresos { get; set; }

        public ICollection<venta> ventas { get; set; }

        public usuario Usuarios
        {
            get => default;
            set
            {
            }
        }

        public usuario Usuarios1
        {
            get => default;
            set
            {
            }
        }

        public usuario Usuarios2
        {
            get => default;
            set
            {
            }
        }
    }
}
