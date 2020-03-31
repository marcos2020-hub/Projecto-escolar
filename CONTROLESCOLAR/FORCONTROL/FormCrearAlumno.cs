using ControlEscolar.Extenciones;
using DataLayer.Contexto;
using DataLayer.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEscolar
{
    public partial class FormCrearAlumno : Form
    {
        
        public FormCrearAlumno()
        {
            InitializeComponent();
        }
       
        private  int ConvertirAUnix(DateTime dateTime)
        {
           return  (Int32)(dateTime.ToUniversalTime().Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }
        private int EsMaculino(bool hombre , bool mujer)
        {
            if (hombre)
                return 1;
            else if (mujer)
                return 0;

            return 0;
            
        }
        // se tiene que usare la palabra async si quieres que corra async 
        private async void button1_Click(object sender, EventArgs e)
        {
            // tienes que validar antes de guardar ciertos campos no pueden estar sin texto
            if (string.IsNullOrEmpty(MatriculaTxt.Text))
            {
                  MessageBox.Show("SU MATRICULA FUE GUARDADA EN LA TABLA ALUMNOS SASTIFACTORIAMENTE");
                return;
            }

            var alumno = new Alumnos {

                FECHADENACIMIENTO = FechaNDateTimePicker.Value.ConvertirAUnix(),
                APELLIDOMATERNO = NombreMText.Text,
                APELLIDOPATERNO = NombrePText.Text,
                CURP = CurpTXT.Text,
                DIRECCION = DirecionTxt.Text,
                MASCULINO = EsMaculino(this.MaculinoradioButto.Checked, FemeninoradioButton.Checked),
                TELEFONO = TelTxt.Text,
                MATRICULA = MatriculaTxt.Text,
                GRADO = GradoInscripcionTxt.Text,
                ULTIMOGRADO = UltimoGradoTxt.Text,
                NOMBRE = NombreTxt.Text,
                ESOLARIDAD = EscolaridadTxt.Text,

            };
            using(var con = new DbContexto())
            {
                try
                {
                    //esto es para que no se te conjele el formulario nada mas es opcional
                    await con.Alumnos.AddAsync(alumno);
                    await con.SaveChangesAsync();
                }
                catch(Exception a){
                    MessageBox.Show(a.Message);
                }
            }
            MatriculaTxt.Text = null;
        }
    }
}
