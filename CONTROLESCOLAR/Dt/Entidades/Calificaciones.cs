using System.ComponentModel;
namespace DataLayer.Entidades

{
	public class CALIFICACIONES
	{
		public int ID { get; set; }
		public string MATERIA { get; set; }
		public string SEMESTRE { get; set; }
		public string GRUPO { get; set; }
		public string CALIFICACION1 { get; set; }
		public string CALIFICACION2 { get; set; }
		public string CALIFICACION3 { get; set; }
		[Browsable(false)]
		public byte[] IMAGEN { get; set; }
	}
}