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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125, Color.Chocolate);
            label4.Text = DateTime.Now.ToString("hh:mm:ss");
            label5.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormAlumnos alumnos = new FormAlumnos();

            alumnos.MdiParent = this;

            alumnos.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormTutoriado tutoriado = new FormTutoriado();

            tutoriado.MdiParent = this;

            tutoriado.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FormSalones salones = new FormSalones();

            salones.MdiParent = this;

            salones.Show();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            FormnNotas notas = new FormnNotas();

            notas.MdiParent = this;

            notas.Show();
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            FormMatricula matricula = new FormMatricula();

            matricula.MdiParent = this;

            matricula.Show();
        }

        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)
        {
            FormDocencia docencia = new FormDocencia();

            docencia.MdiParent = this;

            docencia.Show();
        }

        private void toolStripSplitButton4_ButtonClick(object sender, EventArgs e)
        {
            FormCalificaciones calificaciones = new FormCalificaciones();

            calificaciones.MdiParent = this;

            calificaciones.Show();
        }

        private void toolStripSplitButton5_ButtonClick(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FormCrearAlumno crealumno = new FormCrearAlumno();

            crealumno.MdiParent = this;

            crealumno.Show();
        }
    }
}
