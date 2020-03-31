using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Entidades
{
	// aca teinenes otra clase que se llama igual pero en otro namespace
	public class Docente
	{
		// mapea la llave 
		public int ID { get; set; }
		[Required]
		public String CEDULA { get; set; }
		[Required]
		public String NOMBRE { get; set; }
		[Required]
		public String MATERIAS { get; set; }
		[Required]
		public String HORARIO { get; set; }
		[Required]
		public String DIRECCION { get; set; }
		[Required]
		public String CORREO { get; set; }
		[Required]
		public String TELEFONO { get; set; }
		[Required]
		public String DIAZ { get; set; }
		[Required]
		public String ESPECIALIDAD { get; set; }
		[Required]
		public string PERMISOS { get; set; }
		public long FECHA { get; set; }
	}


}



