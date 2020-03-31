//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Text;

//namespace DataLayer.Entidades
//{
//    public class Alumnos
//    {
//        public int ID { get; set; }
//        [Required]
//        public string MATRICULA { get; set; }
//        [Required]
//        public string NOMBRE { get; set; }
//        public string APELLIDOPATERNO { get; set; }
//        public string APELLIDOMATERNO { get; set; }
//        public long FECHADENACIMIENTO { get; set; }
//        public int? MASCULINO { get; set; }
//        [Required]
//        public string CURP { get; set; }
//        [Required]
//        public string ESOLARIDAD { get; set; }
//        [Required]
//        public string ULTIMOGRADO { get; set; }
//        [Required]
//        public string GRADO { get; set; }
//        [Required]
//        public string DIRECCION { get; set; }
//        [Required]
//        public string TELEFONO { get; set; }


//        [NotMapped]
//        public bool MASCULINOMappaedo
//        {
//            get
//            {
//                return MASCULINO != 0;
//            }
//            set
//            {
//                MASCULINO = value ? 1 : 0;
//            }


//        }
//    }
//}
