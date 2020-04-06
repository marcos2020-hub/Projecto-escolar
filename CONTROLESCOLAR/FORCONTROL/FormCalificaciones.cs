using DataLayer.Contexto;
using DataLayer.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEscolar
{
    public partial class FormCalificaciones : Form
    {
        bool esnuevo = false;
        public CALIFICACIONES CALIFICACIONEs { get; set; }

        public FormCalificaciones()
        {
            InitializeComponent();
            CALIFICACIONESDatagridView.ReadOnly = true;

        }

        private void FormCalificaciones_Load(object sender, EventArgs e)
        {

        }

        //  ABRIR UN NUEVO FORMULARIO DENTRO DE OTRO FORMULARIO
        private void button2_Click(object sender, EventArgs e)
        {
            FormPromedio prom = new FormPromedio();

            prom.MdiParent = this.MdiParent;

            this.Hide();

            prom.Show();

        }

        // ABRIR UN  DATAGRID  O ACTUALIZAR

        private void button1_Click(object sender, EventArgs e)
        {
            using (var con = new DbContexto())
            {
                // alli si aparecio algo que puedo usar ! 
                // asi  que mi recomendacion es que solo lo uses cuando te aprece la palabra using 
                CALIFICACIONESDatagridView.DataSource = con.CALIFICACIONEs.ToList();
                label7.Text = "TOTAL DE REGISTROS INGRESADO A LA TABLA :" + CALIFICACIONESDatagridView.Rows.Count.ToString();
            }
        }

        //  BOTON PARA  GUARDAR  DATOS
        private void button3_Click(object sender, EventArgs e)
        {
            if (CALIFICACIONEs == null)
            {
                var dialog = MessageBox.Show("No has elegido una Calificacion que deses Crear ?", "Guaardar", MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.Cancel)
                    return;
                CALIFICACIONEs = new CALIFICACIONES
                {
                    MATERIA = MateriaText.Text,
                    SEMESTRE = SemestreText.Text,
                    GRUPO = GrupoText.Text,
                    CALIFICACION1 = CaliText.Text,
                    CALIFICACION2 = CaliText2.Text,
                    CALIFICACION3 = CaliText3.Text,
                };
                esnuevo = true;
            }

            using (var con = new DbContexto())
            {
                try
                {
                    if (esnuevo)
                        con.Add(CALIFICACIONEs);
                    else
                    {
                        var resultado = CALIFICACIONEs;

                        if (resultado == null)

                        {
                            throw new Exception("La Calificacion No se Encontro");

                        }
                        resultado.MATERIA = MateriaText.Text;
                        resultado.SEMESTRE = SemestreText.Text;
                        resultado.GRUPO = GrupoText.Text;
                        resultado.CALIFICACION1 = CaliText.Text;
                        resultado.CALIFICACION2 = CaliText2.Text;
                        resultado.CALIFICACION3 = CaliText3.Text;
                        con.Update(CALIFICACIONEs);
                    }

                    con.SaveChanges();

                    MessageBox.Show("Su CAlificacion Capturada Ha sido Guardada");

                    esnuevo = false;

                    MateriaText.Text = CALIFICACIONEs.MATERIA;
                    SemestreText.Text = CALIFICACIONEs.SEMESTRE;
                    GrupoText.Text = CALIFICACIONEs.GRUPO;
                    CaliText.Text = CALIFICACIONEs.CALIFICACION1;
                    CaliText2.Text = CALIFICACIONEs.CALIFICACION2;
                    CaliText3.Text = CALIFICACIONEs.CALIFICACION3;

                    CALIFICACIONESDatagridView.DataSource = con.CALIFICACIONEs.ToList<CALIFICACIONES>();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + " " + a.StackTrace + " " + a.InnerException?.Message);
                }
            }
        }


        // BUSCAR IMAGEN 

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)

            {
                ImagenText1.Image = Image.FromFile(dialog.FileName);

                botonCircular5.Tag = File.ReadAllBytes(dialog.FileName);
            }
        }


        //  AKI  DAMOS ACCESO A ELIMINAR  UN REGISTRO 
        private void button5_Click(object sender, EventArgs e)
        {
            if (esnuevo || CALIFICACIONEs == null)
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
                    con.CALIFICACIONEs.Remove(CALIFICACIONEs);
                    con.SaveChanges();
                    MateriaText.Text = string.Empty;
                    SemestreText.Text = string.Empty;
                    GrupoText.Text = string.Empty;
                    CaliText.Text = string.Empty;
                    CaliText2.Text = string.Empty;
                    CaliText3.Text = string.Empty;

                    CALIFICACIONEs = null;
                    CALIFICACIONESDatagridView.DataSource = con.CALIFICACIONEs.ToList<CALIFICACIONES>();
                }

                catch
                {
                    MessageBox.Show("Error al Borrar");

                }
            }
        }

        private void botonCircular1_Click(object sender, EventArgs e)
        {
            using (var con = new DbContexto())
            {
                // alli si aparecio algo que puedo usar ! 
                // asi  que mi recomendacion es que solo lo uses cuando te aprece la palabra using 
                CALIFICACIONESDatagridView.DataSource = con.CALIFICACIONEs.ToList();
                label7.Text = "TOTAL DE REGISTROS INGRESADO A LA TABLA :" + CALIFICACIONESDatagridView.Rows.Count.ToString();
            }
        }

        private void botonCircular2_Click(object sender, EventArgs e)
        {
            FormPromedio prom = new FormPromedio();

            prom.MdiParent = this.MdiParent;

            this.Hide();

            prom.Show();
        }

        private void botonCircular3_Click(object sender, EventArgs e)
        {
            if (esnuevo || CALIFICACIONEs == null)
            {
                MessageBox.Show("Desea Borrar La Calificacion");
            }
            var dialog = MessageBox.Show("Esta Seguro Ke desea Borrar la Calificacion?", "Guardar", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.Cancel)
                return;

            using (var con = new DbContexto())
            {
                try
                {
                    con.CALIFICACIONEs.Remove(CALIFICACIONEs);
                    con.SaveChanges();
                    MateriaText.Text = string.Empty;
                    SemestreText.Text = string.Empty;
                    GrupoText.Text = string.Empty;
                    CaliText.Text = string.Empty;
                    CaliText2.Text = string.Empty;
                    CaliText3.Text = string.Empty;

                    CALIFICACIONEs = null;
                    CALIFICACIONESDatagridView.DataSource = con.CALIFICACIONEs.ToList();
                }

                catch
                {
                    MessageBox.Show("Error al Borrar");
                }
            }
        }
    
        private void botonCircular4_Click_1(object sender, EventArgs e)
        {
            if (CALIFICACIONEs == null)
            {
                var dialog = MessageBox.Show("No has elegido una Calificacion que deses Crear ?", "Guaardar", MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.Cancel)
                    return;
                CALIFICACIONEs = new CALIFICACIONES
                {
                    MATERIA = MateriaText.Text,
                    SEMESTRE = SemestreText.Text,
                    GRUPO = GrupoText.Text,
                    CALIFICACION1 = CaliText.Text,
                    CALIFICACION2 = CaliText2.Text,
                    CALIFICACION3 = CaliText3.Text,
                };
                esnuevo = true;
            }

            using (var con = new DbContexto())
            {
                try
                {
                    if (esnuevo)
                        con.Add(CALIFICACIONEs);
                    else
                    {
                        var resultado = CALIFICACIONEs;

                        if (resultado == null)

                        {
                            throw new Exception("La Calificacion No se Encontro");

                        }
                        resultado.MATERIA = MateriaText.Text;
                        resultado.SEMESTRE = SemestreText.Text;
                        resultado.GRUPO = GrupoText.Text;
                        resultado.CALIFICACION1 = CaliText.Text;
                        resultado.CALIFICACION2 = CaliText2.Text;
                        resultado.CALIFICACION3 = CaliText3.Text;
                        con.Update(CALIFICACIONEs);
                    }

                    con.SaveChanges();

                    MessageBox.Show("Su CAlificacion Capturada Ha sido Guardada");

                    esnuevo = false;

                    MateriaText.Text = CALIFICACIONEs.MATERIA;
                    SemestreText.Text = CALIFICACIONEs.SEMESTRE;
                    GrupoText.Text = CALIFICACIONEs.GRUPO;
                    CaliText.Text = CALIFICACIONEs.CALIFICACION1;
                    CaliText2.Text = CALIFICACIONEs.CALIFICACION2;
                    CaliText3.Text = CALIFICACIONEs.CALIFICACION3;

                    CALIFICACIONESDatagridView.DataSource = con.CALIFICACIONEs.ToList();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message + " " + a.StackTrace + " " + a.InnerException?.Message);
                }
            }
        }

        private void botonCircular5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)

            {
                ImagenText1.Image = Image.FromFile(dialog.FileName);

                botonCircular5.Tag = File.ReadAllBytes(dialog.FileName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void botonCircular6_Click(object sender, EventArgs e)
        {
            MateriaText.Text = string.Empty;
            SemestreText.Text = string.Empty;
            GrupoText.Text = string.Empty;
            CaliText.Text = string.Empty;
            CaliText2.Text = string.Empty;
            CaliText3.Text = string.Empty;
            MateriaText.Focus(); 
        }
    }
}
        
