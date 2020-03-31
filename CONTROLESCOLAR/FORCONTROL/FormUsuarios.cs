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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ConexionSingelton.Ejecutar((comando) =>

            //{
            //    try
            //    {
            //        var query = new StringBuilder();
            //        query.Append(" INSERT INTO CLAVE ");
            //        query.Append(" ");
            //        query.Append("(USUARIO,CLAVE)");
            //        query.Append("VALUES(@usuario,@clave)");
            //        comando.CommandText = query.ToString();
            //        comando.Parameters.AddWithValue("@usuario", textBox1.Text);
            //        comando.Parameters.AddWithValue("@clave", textBox2.Text);


            //        int resultado = comando.ExecuteNonQuery();
            //        if (resultado > 0)
            //        {
            //            linkLabel1.Text = " SUS DATOS SE HAN GUARDADO SASTIFACTORIAMENTE ";

            //            textBox1.Text = "";
            //            textBox2.Text = "";
            //            textBox1.Focus();
            //        }
            //    }

            //    catch (Exception error)
            //    {
            //        MessageBox.Show(error.Message);
            //    }
            //});
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ConexionSingelton.Ejecutar((comando) =>
            //{
            //    try
            //    {
            //        var query = new StringBuilder();
            //        query.Append(" UPDATE CLAVE SET ");
            //        query.Append("");
            //        query.Append("USUARIO=@usuario,CLAVE=@clave");
            //        query.Append(" ");
            //        query.Append("WHERE ID=@id;");
            //        comando.CommandText = query.ToString();
            //        comando.Parameters.AddWithValue("@id", textBox3.Text);
            //        comando.Parameters.AddWithValue("@usuario", textBox1.Text);
            //        comando.Parameters.AddWithValue("@clave", textBox2.Text);


            //        int resultado = comando.ExecuteNonQuery();
            //        if (resultado > 0)
            //        {
            //            linkLabel1.Text = " SUS DATOS SE HAN CORREGIDOS SASTIFACTORIAMENTE ";

            //            textBox1.Text = "";
            //            textBox2.Text = "";
            //            textBox3.Text = "";
            //            textBox1.Focus();
            //        }


            //    }
            //    catch (Exception error)
            //    {
            //        MessageBox.Show(error.Message);
            //    }


            //});
        }
    
        private void button5_Click(object sender, EventArgs e)
        {


            // Cuando hago click en el botón Buscar, procedo a buscar en la Base de Datos.

            //string sql = "SELECT * FROM CLAVE WHERE ID=" + textBox3.Text;

            //ConexionSingelton.Ejecutar((comando) =>
            //{

            //    try
            //    {
            //        comando.CommandText = sql;
            //        var reader = comando.ExecuteReader();


            //        if (reader.Read())
            //        {

            //            textBox3.Text = reader[0].ToString();
            //            textBox1.Text = reader[1].ToString();
            //            textBox2.Text = reader[2].ToString();

            //            linkLabel1.Text = "SUS DATOS AN SIDO MOSTRADOS PARA SU ACTUALIZACION";
            //        }

            //        else
            //            linkLabel1.Text = "Ningun registro encontrado con el Id ingresado";

            //        reader.Close();
            //    }

            //    catch (Exception ex)
            //    {

            //        MessageBox.Show("Erro: " + ex.ToString());

            //    }



            //});


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //String Sql = "DELETE  FROM CLAVE  where  ID=" + textBox1.Text;

            //SQLiteConnection con = new SQLiteConnection("Data Source=ControlEscolar.db;Version=3;");
            //SQLiteCommand cmd = new SQLiteCommand(Sql, con);
            //cmd.CommandType = CommandType.Text;
            //con.Open();

            //try
            //{
            //    int i = cmd.ExecuteNonQuery();
            //    if (i > 0)

            //        linkLabel1.Text = " LOS REGISTROS SE ELIMINARON CORRECTAMENTE , YA PUEDE PROCEDER CON SU NUEVO REGISTRO";

            //    textBox1.Text = "";
            //    textBox2.Text = "";
            //    textBox1.Focus();


            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("Error:" + ex.ToString());

            //}
            //finally
            //{

            //}
            //con.Close();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
           
            textBox1.Focus();
            linkLabel1.Text = "SUS CASILLAS SE LIMPIARON CORRECTAMENTE ";
        }
    }
}
