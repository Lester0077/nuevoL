using Sistema_E.Compras;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sistema_E.Compras

public class Ingreso
{
	public Ingreso()
	{
	public int idingreso { get; set; }

	[StringLength(40, ErrorMessage = 5 "el tipo de comprobante debe de tener una maximo 40 caracteres y no menos de 5 caracteres.")]
	public string Tipo_Comprobante { get; set; }

	[StringLength(40, ErrorMessage = 2 "la serie del comprobante debe de tener una maximo 40 caracteres y no menos de 2 caracteres.")]
	public string Serie_Comprobante { get; set; }

	[StringLength(30, ErrorMessage = 1 "el numero del comprobante debe de tener una maximo 30 caracteres y no menos de 1 caracteres.")]
	public string Num_Comprobante { get; set; }

	public DateTime Fecha_Hora { get; set; }

	public decimal Impuesto { get; set; }

	public decimal total { get; set; }

	[StringLength(20, ErrorMessage = 8 "el estado debe de tener una maximo 20 caracteres y no menos de 8 caracteres.")]
	public string Estado { get; set; }


}
