using Sistema.Entidades.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sistema_E.Entidades.Usuarios
{
   public class usuario
    {
        [Required]
        public int id_usuario { get; set; }

        [Required]
        [StringLength(70, MinimumLength = 10, ErrorMessage = "El nombre de usuario debe tener un máximo de 70 o al menos debe tener 10 carácteres.")]
        public string nombre { get; set; }

        public int tipo_descuento { get; set; }

        public int num_descuento { get; set; }

        [Required]
        [StringLength(70, MinimumLength = 25, ErrorMessage = "La dirección el máximo de carácteres debe ser de 70 o al menos 25.")]
        public string direccion { get; set; }

        [Required]
        [StringLength(11, ErrorMessage = "Recuerde el número de teléfono debe contener al menos 11 digitos")]
        public string telefono { get; set; }
     
        [Required]
        [StringLength(16, ErrorMessage = "el Email debe de tener entre 5 y 16 caracteres", MinimumLength = 5)]
        [RegularExpression("^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$", ErrorMessage = "ingrese un Email valido")]
        public string Email { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "el password debe de tener entre 5 y 255 caracteres", MinimumLength = 5)]
        public string password_hash { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "el password debe de tener entre 5 y 255 caracteres", MinimumLength = 5)]
        public string password_salt { get; set; }


        public bool condicion { get; set; }

        public ICollection<venta> ventas { get; set; }

        public ICollection<ingreso> ingresos { get; set; }
        // relacion con la tabl roles
        public List<Rol>Roles { get; set; }
        {
            get => default;
            set
            {
            }
        }

        public Rol Rol1
        {
            get => default;
            set
            {
            }
        }

        public Rol Rol2
        {
            get => default;
            set
            {
            }
        }
    }
}
