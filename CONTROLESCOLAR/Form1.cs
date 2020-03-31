using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Contexto;

namespace ControlEscolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(123, Color.Azure);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validarusuario();
        }

       

        void Validarusuario()
        {
            using(var con = new DbContexto())
            {
               var resultado = con.Usuarios.FirstOrDefault(x => x.USUARIO == textBox1.Text && x.CLAVE == textBox2.Text);
                if (resultado == null)
                    MessageBox.Show( "¿ Si No Tienes una Cuenta ,   Registrate ?");
                else
                {
                    new FormMenu().Show();
                    this.Hide();
                }
            }


            //ConexionSingelton.Ejecutar((cmd) =>
            //{
            //    String select = "SELECT ID,USUARIO FROM CLAVE where USUARIO=@us and CLAVE=@clave LIMIT 1";
            //    try
            //    {
            //        cmd.CommandText = select;
            //        cmd.Parameters.AddWithValue("@us", textBox1.Text);
            //        cmd.Parameters.AddWithValue("@clave", textBox2.Text);
            //        leer = cmd.ExecuteReader();
            //        var hasUser = leer.HasRows;

            //        if (hasUser)
            //        {
            //            this.Hide();
            //            FormMenu menu = new FormMenu();
            //            menu.Show();
            //        }

            //        else linkLabel1.Text = "¿ Si No Tienes una Cuenta ,   Registrate ?";
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //    finally { leer.Close(); }
            //});
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUsuarios frmusuarios = new FormUsuarios();
            frmusuarios.Show();
        }
    }
}
