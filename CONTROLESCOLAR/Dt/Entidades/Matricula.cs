using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Entidades
{
     public class Matricula
    {
		// mira lo que ha generado es codigo incorreceto
		//public static List<Matricula> DataSource { get; set; }
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID { get; set; }
		public string MATRICULA { get; set; }
		public string NOMBRE { get; set; }
		public string APELLIDOS { get; set; }
		public string GRADO { get; set; }
		public string GRUPO { get; set; }
		public string CORREO { get; set; }

	}
}
