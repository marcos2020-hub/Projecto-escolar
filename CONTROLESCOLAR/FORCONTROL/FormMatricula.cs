
using DataLayer.Contexto;// aqui 
using DataLayer.Entidades;// aqui ok
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// digamos que no tubieras estos dos te lo agrega automatico 

namespace ControlEscolar
{
    public partial class FormMatricula : Form
    {
        bool esnuevo = false;
        public Matricula Matricula { get; set; } // 

        public FormMatricula()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125, Color.Tomato);
            panel2.BackColor = Color.FromArgb(125, Color.Tomato);
            MatriculadataGridView.ReadOnly = true;
        }

        private void FormMatricula_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // te sale error pudes usar el foco para arreglarlo
            // aqui aprece un monton de opciones que no son validas 
            using (var con = new DbContexto())
            {
                // alli si aparecio algo que puedo usar ! 
                // asi  que mi recomendacion es que solo lo uses cuando te aprece la palabra using 
                MatriculadataGridView.DataSource = con.MATRICULA.ToList<Matricula>();
                label8.Text = "TOTAL DE REGISTROS INGRESADO A LA TABLA :" + MatriculadataGridView.Rows.Count.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (var con = new DbContexto())
            {
                try
                {
                   var check = con.MATRICULA.Select(x => x.MATRICULA).FirstOrDefault(x => x.Trim().ToLower().Equals(MatriculaText.Text.Trim().ToLower()));
                    
                    if (Matricula == null) // aqui ok podes tener este codigo aui tambien ok
                    {
                        var dialog = MessageBox.Show("No As Elejido una MAtricula k desea Crear Nueva?",
                            "Guardar", MessageBoxButtons.OKCancel);
                        if (dialog == DialogResult.Cancel)
                            return;
                        if (check != null)
                        {
                            MessageBox.Show("Esta Matricula ya Existe");
                            return;

                        }
                        Matricula = new Matricula
                        {
                            MATRICULA = MatriculaText.Text.Trim(),
                            NOMBRE = NombreText.Text,
                            APELLIDOS = ApellidosText.Text,
                            GRADO = GradoText.Text,
                            GRUPO = GrupoText.Text,
                            CORREO = CorreoText.Text,
                        };
                        esnuevo = true;
                    }
                   
                        if (esnuevo)
                        con.MATRICULA.Add(Matricula);
                    else
                    {
                        if(check != null)
                        {
                            if (!check.Equals(Matricula.MATRICULA))
                            {
                                MessageBox.Show("Esta Matricula ya Existe");
                                return;
                            }
                        }
                        Matricula.MATRICULA = MatriculaText.Text.Trim();
                        Matricula.NOMBRE = NombreText.Text;
                        Matricula.APELLIDOS = ApellidosText.Text;
                        Matricula.GRADO = GradoText.Text;
                        Matricula.GRUPO = GrupoText.Text;
                        Matricula.CORREO = CorreoText.Text;
                        con.MATRICULA.Update(Matricula);
                    }
                    con.SaveChanges();
                    MessageBox.Show("Sus Cambios An Sido Guardados");
                    esnuevo = false;
                    MatriculaText.Text = Matricula.MATRICULA;
                    NombreText.Text = Matricula.NOMBRE;
                    ApellidosText.Text = Matricula.APELLIDOS;
                    GradoText.Text = Matricula.GRADO;
                    GrupoText.Text = Matricula.GRADO;
                    CorreoText.Text = Matricula.CORREO;
                    IDtxt.Text = Matricula.CORREO;

                    MatriculadataGridView.DataSource = con.MATRICULA.ToList<Matricula>();

                }
                catch (Exception a)
                {
#if DEBUG
                    MessageBox.Show(a.Message+" "+ a.StackTrace+" "+ a.InnerException?.Message);
#else
                         MessageBox.Show("Hubo un error prube de nuevo");
#endif
                    // aqui te recomiendo hacer una directiva si estas en deubug que te amuestre el error de systema
                    // Si ya esta publicado que amuestre este error generico  

                }
            }
        }

        private void MatriculadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           Matricula = (Matricula)MatriculadataGridView.CurrentRow.DataBoundItem;
            if (Matricula != null)
            {
                MatriculaText.Text = Matricula.MATRICULA;
                NombreText.Text = Matricula.NOMBRE;
                ApellidosText.Text = Matricula.APELLIDOS;
                GradoText.Text = Matricula.GRADO;
                GrupoText.Text = Matricula.GRADO;
                CorreoText.Text = Matricula.CORREO;
                 IDtxt.Text= Matricula.CORREO;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Matricula = null;
            MatriculaText.Text = string.Empty;
            NombreText.Text = string.Empty;
            ApellidosText.Text = string.Empty;
            GradoText.Text = string.Empty;
            GrupoText.Text = string.Empty;
            CorreoText.Text = string.Empty;
            IDtxt.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (esnuevo || Matricula == null)
            {
                MessageBox.Show("Esta Por Borrar");
            }

            var dialog = MessageBox.Show("Esta seguro de borrar esta nota?",
         "Guardar", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.Cancel)
                return;
            using (var con = new DbContexto())
            {
                try
                {
                    con.MATRICULA.Remove(Matricula);
                    con.SaveChanges();
                    MatriculaText.Text = string.Empty;
                    NombreText.Text = string.Empty;
                    ApellidosText.Text = string.Empty;
                    GradoText.Text = string.Empty;
                    GrupoText.Text = string.Empty;
                    CorreoText.Text = string.Empty;
                    IDtxt.Text = string.Empty;
                    Matricula = null;
                    MatriculadataGridView.DataSource = con.MATRICULA.ToList<Matricula>();
                }

                catch 
                {
                    MessageBox.Show("Error al Borrar");
                }
            }
        }
    }
}
