using ControlEscolar.Extenciones;
using DataLayer.Contexto;
using DataLayer.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//  ControlEscolar eso haora un namespace que contiene muchos componentes 

namespace ControlEscolar
{

    // aqui tienes una clase que ya se llama docente 
    // entoces que pasa aqui  ?? visual studio no entiende que clase es la que vas a usar asi que escoje tu clase interna i no la otra 

    public partial class FormDocencia : Form
    {
        bool Esnuevo = false;
        public Docente Docente { get; set; }
        public FormDocencia()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125, Color.Tomato);

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Estas seguro de guardar?",
            "Guardar", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.Cancel)
                return;

            button2.Enabled = false;
            if (Docente == null)
            {
                MessageBox.Show("Porfavor busca un docente antes de editarlo");
            }
            else
            {
                using (var con = new DbContexto())
                {
                    try
                    {
                        // aqui faltan campos
                        this.Docente.CEDULA = CedulaText.Text;
                        this.Docente.NOMBRE = NombreText.Text;
                        this.Docente.MATERIAS = MateriaText.Text;
                        this.Docente.HORARIO = HorarioText.Text;
                        this.Docente.DIRECCION = DireccionText.Text;
                        this.Docente.CORREO = CorreoText.Text;
                        this.Docente.TELEFONO = TelefonoText.Text;
                        this.Docente.DIAZ = DiazText.Text;
                        this.Docente.ESPECIALIDAD = EspecialidadText.Text;
                        this.Docente.PERMISOS = PermisoText.Text;
                        this.Docente.FECHA = FechaDateTimePicker.Value.ConvertirAUnix();
                        if (Esnuevo)
                            con.Add(Docente);
                        else
                            con.Update(Docente);

                        await con.SaveChangesAsync();
                        // depues de guardar asegurate de los cambiosb // aqui faltan campos
                        Busquedatxt.Text = this.Docente.NOMBRE;
                        CedulaText.Text = this.Docente.CEDULA;
                        NombreText.Text = this.Docente.NOMBRE;
                        MateriaText.Text = this.Docente.MATERIAS;
                        HorarioText.Text = this.Docente.HORARIO;
                        DireccionText.Text = this.Docente.DIRECCION;
                        CorreoText.Text = this.Docente.CORREO;
                        TelefonoText.Text = this.Docente.TELEFONO;
                        DiazText.Text = this.Docente.DIAZ;
                        EspecialidadText.Text = this.Docente.ESPECIALIDAD;
                        PermisoText.Text = this.Docente.PERMISOS;
                        FechaDateTimePicker.Value = this.Docente.FECHA.UnixADateTime();

                        MessageBox.Show("SUS DATOS SE HAN GUARDADO");
                        Esnuevo = false;
                        this.button3.Text = "Crear nuevo ";
                        this.Busquedatxt.Enabled = true;
                        this.button1.Enabled = true;

                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("No se pudo editar error " + a.Message + a.InnerException.Message + a.StackTrace);
                    }
                }

            }
            button2.Enabled = true;





        }

        private async void DoncenteText_TextChanged(object sender, EventArgs e)
        {
            if (Busquedatxt.Text.Length < 1)
                return;

            using (var con = new DbContexto())
            {


                // no se cual es docente async es para que no se trabe el formulario Asegurate de poner bien los nombres
                var resultado = await con.Docentes.Where(x =>
              x.NOMBRE.ToLower().Contains(this.Busquedatxt.Text)
            ).Select(x => x.NOMBRE).Take(10).ToArrayAsync();

                if (resultado.Length > 0)
                {

                    var res = new AutoCompleteStringCollection();
                    this.Busquedatxt.AutoCompleteMode = AutoCompleteMode.Suggest;
                    this.Busquedatxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    res.AddRange(resultado);
                    Busquedatxt.AutoCompleteCustomSource = res;

                }
            }

        }
        private void Limpiar()
        {

            CedulaText.Text = string.Empty;
            NombreText.Text = string.Empty;
            MateriaText.Text = string.Empty;
            HorarioText.Text = string.Empty;
            DireccionText.Text = string.Empty;
            CorreoText.Text = string.Empty;
            TelefonoText.Text = string.Empty;
            DiazText.Text = string.Empty;
            EspecialidadText.Text = string.Empty;
            PermisoText.Text = string.Empty;
            FechaDateTimePicker.Value = DateTime.Now;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Limpiar();
            using (var con = new DbContexto())
            {
                try
                {
                    // no se cual es docente async es para que no se trabe el formulario Asegurate de poner bien los nombres
                    var resultado = await con.Docentes.Where(x => x.NOMBRE.Trim().ToLower().Contains(this.Busquedatxt.Text.Trim().ToLower())).FirstOrDefaultAsync();
                    if (resultado == null)
                    {
                        MessageBox.Show("No encontre a nadie");
                    }
                    else
                    {
                        Docente = resultado;
                        //aqui llenas tu formulario con la datos de resultado
                        Busquedatxt.Text = this.Docente.NOMBRE;
                        CedulaText.Text = this.Docente.CEDULA;
                        NombreText.Text = this.Docente.NOMBRE;
                        MateriaText.Text = this.Docente.MATERIAS;
                        HorarioText.Text = this.Docente.HORARIO;
                        DireccionText.Text = this.Docente.DIRECCION;
                        CorreoText.Text = this.Docente.CORREO;
                        TelefonoText.Text = this.Docente.TELEFONO;
                        DiazText.Text = this.Docente.DIAZ;
                        EspecialidadText.Text = this.Docente.ESPECIALIDAD;
                        PermisoText.Text = this.Docente.PERMISOS;
                        FechaDateTimePicker.Value = this.Docente.FECHA.UnixADateTime();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al buscara");
                }
            }

            button1.Enabled = true;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (!Esnuevo)
            {
                // que texto quieres en guadar PERA no solo editar por k ya ves k lo oprimes dos veses // yo utilizaria esta palabra o quieres editar? por que el boton crear no crea nada solo indica al programa que es nuevo post
                Limpiar();

                this.Busquedatxt.Text = string.Empty;
                Esnuevo = true;
                Docente = new Docente();
                this.button3.Text = "Deseas Cancelar?";
                this.Busquedatxt.Enabled = false;
                this.button1.Enabled = false;
            }
            else
            {
                Esnuevo = false;
                Docente = null;
                this.button3.Text = "Crear nuevo ";
                this.Busquedatxt.Enabled = true;
                this.button1.Enabled = true;
            }

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Estas seguro de borrar?",
                       "Guardar", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.Cancel)
                return;


            if (Docente == null)
            {
                MessageBox.Show("Porfavor busca un docente antes de Borrar");
            }
            else
            {
                using (var con = new DbContexto())
                {
                    try
                    {

                        var result = con.Docentes.FirstOrDefault(x => x.ID == Docente.ID);
                        if (result == null)
                        {
                            MessageBox.Show("No se puede borrar el usuario no existe");
                            return;
                        }
                        con.Remove(result);
                        await con.SaveChangesAsync();

                        MessageBox.Show("El dato a sido borrado");

                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("No se pudo editar error " + a.Message + a.InnerException.Message + a.StackTrace);
                    }
                }

            }
        }
    }
}

