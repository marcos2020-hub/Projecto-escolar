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
    public partial class FormSalones : Form
    {
        public FormSalones()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125, Color.Tomato);

            using (var con = new DbContexto()) 
            {
                Mostrar.DataSource = con.Aulas.ToList<AULAS>();
                label5.Text = " Total de Registros: " + Convert.ToString(Mostrar.Rows.Count - 1);
            }
        }

        private void FormSalones_Load(object sender, EventArgs e)
        {
            using(var con = new DbContexto())
            {
               var result = con.Aulas.ToArray();
                GradosCombox.Items.AddRange(result);
            }
        }

        private void GradosCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item =(AULAS) GradosCombox.SelectedItem;
            Ocupadastxt.Text = item?.Ocupadas?.ToString();
            Totaltxt.Text = item?.Total?.ToString();

        }
    }
}
