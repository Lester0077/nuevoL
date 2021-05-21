﻿using Sistema.Entidades.Ventas;
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


        public String codigo_articilo { get; set; }

        public String nombre_articulo { get; set; }

        public decimal venta_articulo { get; set; }

        public float stock_articulo { get; set; }

        public String descripcion_articulo { get; set; }

        public int condicion_articulo { get; set; }

        public int idmarca { get; set; }

        public ICollection<detalle_venta> detalle_ventas { get; set; }

        public ICollection<detalle_ingreso> detalle_Ingresos { get; set; }

        public venta venta
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