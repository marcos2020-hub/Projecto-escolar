using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entidades
{
	public class AULAS
	{
		public int ID { get; set; }
		public int? Total { get; set; }
		public int? Ocupadas { get; set; }
		public override string ToString()
		{
			return ID.ToString();
		}

	}
}
