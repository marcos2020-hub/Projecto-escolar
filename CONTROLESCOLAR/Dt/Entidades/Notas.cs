using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Entidades
{
	public class NOTAS
	{
		public int ID { get; set; }
		[Required]
		public string TRIMESTRE { get; set; }
		[Required]
		public string CURSO { get; set; }
		[Required]
		public string DESCRIPCION { get; set; }
		[Required]
		public string NOTA { get; set; }
	}
}
