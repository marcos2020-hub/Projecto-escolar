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
   public partial class FormCalificaciones : Form
    {     
        public FormCalificaciones()
        {
            InitializeComponent();
        }

        private void FormCalificaciones_Load(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            FormPromedio prom = new FormPromedio();

            prom.MdiParent = this.MdiParent;

            this.Hide();

            prom.Show();

        }
    }
}
