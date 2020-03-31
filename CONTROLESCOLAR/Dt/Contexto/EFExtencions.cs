using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Contexto
{
	public static class EFExtencions
	{
		public static bool Contiene(this string val, string query)
		{
			
			return val.Trim().ToLower().Contains(query.Trim().ToLower());



		}
	}

}
