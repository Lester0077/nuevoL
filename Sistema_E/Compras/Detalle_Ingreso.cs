using Sistema_E.Compras;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sistema_E.Compras

public class Detalle_Ingreso
{
	public Detalle_Ingreso()
	{
    public int id_Detalle_Ingreso { get; set; }

	public int Cantidad { get; set; }

	public decimal precio { get; set; }

	List<ingreso> Ingresos { get; set; }
	List<articulo> Articulos { get; set; }
}
}
