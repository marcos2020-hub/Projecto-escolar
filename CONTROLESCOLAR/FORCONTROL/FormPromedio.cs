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
    public partial class FormPromedio : Form
    {
        public FormPromedio()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125, Color.Tomato);
          //  label3.Text = " Total de Registros: " + Convert.ToString(Mostrar.Rows.Count - 1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormPromedioGeneral_Load(object sender, EventArgs e)
        {

        }
    }
}
