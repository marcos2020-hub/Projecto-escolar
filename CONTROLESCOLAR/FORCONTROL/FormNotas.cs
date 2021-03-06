﻿using DataLayer.Contexto;
using DataLayer.Entidades;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ControlEscolar
{
    public partial class FormnNotas : Form
    {
        //esta variable la vamos a usar para mapearla  al formulario 
        // para que cuando el usuario crea o edita una nota todos eso datos se mapaen a esto variable 
        // si este varible es null quire decir que el usuario no esta editanto o creando asi que hat que guiarlo 
        // para que escoja editar o crear una nueva nota 

        public NOTAS NotaCorriente { get; set; }
		bool esnuevo = false;

		public FormnNotas()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125, Color.Tomato);
			MostrarNotas.ReadOnly = true;

		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            using (var con = new DbContexto())
            {
                MostrarNotas.DataSource = con.NOTAS.ToList<NOTAS>();
                label7.Text = "TOTAL DE REGISTROS INGRESADO A LA TABLA :" + MostrarNotas.Rows.Count.ToString();

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // guardar es un poco especial en tu caso 
            // por que aqui tienes que avriguar si el usuario es editando o creado un post nuevo 
            // pero ya me doy cuenta de que no necesito la variable esnuevo  por que puedo averiguarlo con la otra 
            // si la nota esta en null pues es una nota nueva 7
            // se to olvida este blocke aqui validas si la varble eata null 
            if (NotaCorriente == null)
            {
                var dialog = MessageBox.Show("No has eligido una nota deseas crear una nueva ?",
            "Guardar", MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.Cancel)
                    return;
                NotaCorriente = new NOTAS
                {
                    CURSO = CursosText.Text.Trim(),
                    DESCRIPCION = DescripcionText.Text,
                    NOTA = NotaText.Text,
                    TRIMESTRE = TrimestreText.Text
                };
                esnuevo = true;// luego aqui pones si es nuevo 

            }

            using (var con = new DbContexto())
            {
                try
                {
                    if (esnuevo)
                        con.Add(NotaCorriente);
                    else
                    {
						//hay un error con linq no esta compilando bien a sql voy a mirar depues
						var resultado = NotaCorriente;
                        if (resultado == null)
                        {
                            throw new Exception("LaNota no se encontro ");
                        }
                        resultado.CURSO = CursosText.Text.Trim();
                        resultado.DESCRIPCION = DescripcionText.Text;
                        resultado.NOTA = NotaText.Text;
                        resultado.TRIMESTRE = TrimestreText.Text;
                        con.Update(NotaCorriente);
                    }


                    con.SaveChanges();
					MessageBox.Show("Sus Cambios han sido Guardados");
					esnuevo = false;
					CursosText.Text = NotaCorriente.CURSO;
                    DescripcionText.Text = NotaCorriente.DESCRIPCION;
                    NotaText.Text = NotaCorriente.NOTA;
                    TrimestreText.Text = NotaCorriente.TRIMESTRE;
                    IDText.Text = NotaCorriente.ID.ToString();

                    MostrarNotas.DataSource = con.NOTAS.ToList<NOTAS>();
					
				}

                catch (Exception a)
                {

                    MessageBox.Show("Hubo un error prube de nuevo");
                }
            }



        }
        // aqui cremos una funcion para buscar 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var contexto = new DbContexto())
                {
                    // trim borra los espac // esta falladon la compilacion de C# a sql luego miro por que pero te lo resuelvo asi mientras
                    var resultado = contexto.NOTAS.Where(x => 
                    x.CURSO.Trim().ToLower().Contains
                    (CursosText.Text.ToLower().Trim())
                     && x.DESCRIPCION
                    .Contiene(DescripcionText.Text)
                     && x.ID.ToString()
                    .Contiene(IDText.Text)
                      && x.TRIMESTRE
                    .Contiene(TrimestreText.Text)
                     && x.NOTA
                    .Contiene(NotaText.Text)).ToList();
                    // si la lista es menor a 1 entoces no se encontro nada y terminamos la funcion con return;
                    if (resultado.Count < 1)
                    {
                        MessageBox.Show("No se Encontro a nadie conesas caracteristiscas");
                        return;
                    }
                    // y si la lista tiene resultados pues le metemos esos datos aqui 
                    MostrarNotas.DataSource = resultado;
                    label7.Text = "TOTAL DE REGISTROS BUSCADOS EN LA TABLA :" + MostrarNotas.Rows.Count.ToString();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Hubo un error al Buscar prube de nuevo");
            }

        }

        private void MostrarNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // no me acuerdo mucho como se saca un objeto de un data gridview pero creo que es haci
            // DataBoundItem es de tipo object que un tipo generico asi que hay que hacer un object casting (NOTAS)
            var nota = (NOTAS)MostrarNotas.CurrentRow.DataBoundItem;
            if (nota != null)
            {
                // si la nota selecionada no es null pues se la cargamos ala variable globa
                NotaCorriente = nota;
                CursosText.Text = NotaCorriente.CURSO;
                DescripcionText.Text = NotaCorriente.DESCRIPCION;
                NotaText.Text = NotaCorriente.NOTA;
                TrimestreText.Text = NotaCorriente.TRIMESTRE;
                IDText.Text = NotaCorriente.ID.ToString();

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            NotaCorriente = null;
			
			CursosText.Text = string.Empty;
			DescripcionText.Text = string.Empty;
			NotaText.Text = string.Empty;
			TrimestreText.Text = string.Empty;
			IDText.Text = string.Empty;
			// y el resto de codigo para limpiar

		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (esnuevo || NotaCorriente == null) {
				MessageBox.Show("Para poder borrar tienes que elegir una nota de la base de datos");
        }	
			var dialog = MessageBox.Show("Esta seguro de borrar esta nota?",
		 "Guardar", MessageBoxButtons.OKCancel);
			if (dialog == DialogResult.Cancel)
				return;
			using(var con = new DbContexto())
			{
				try
				{
					con.NOTAS.Remove(NotaCorriente);
					con.SaveChanges();
					CursosText.Text = string.Empty;
					DescripcionText.Text = string.Empty;
					NotaText.Text = string.Empty;
					TrimestreText.Text = string.Empty;
					IDText.Text = string.Empty;
                    NotaCorriente = null;
					MostrarNotas.DataSource = con.NOTAS.ToList<NOTAS>();
				}
				catch
				{
					MessageBox.Show("Error al borrar");
				}
			}
		
		}
	}
}

