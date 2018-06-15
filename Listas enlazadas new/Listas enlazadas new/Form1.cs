using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_enlazadas_new
{
    public partial class Form1 : Form
    {
        Agenda agenda = new Agenda();
        Datos persona;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            Datos persona = new Datos();

            persona.Nombre = txtNombre.Text;
            persona.Appaterno = txtApepaterno.Text;
            persona.Apmaterno = txtApmaterno.Text;
            persona.Telefono = txtTelefono.Text;
            persona.Edad = txtEdad.Text;
            persona.Email = txtEmail.Text;
            agenda.AgregarInicio(persona);
            MessageBox.Show("Contacto Agregado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNombre.Clear();
            txtApepaterno.Clear();
            txtApmaterno.Clear();
            txtTelefono.Clear();
            txtEdad.Clear();
            txtEmail.Clear();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Datos contacto = agenda.Buscar(txtTelefono.Text);
            if (agenda.Buscar(txtTelefono.Text) == null)
            {
                MessageBox.Show("Contacto no encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                txtNombre.Text = contacto.Nombre;
                txtApepaterno.Text = contacto.Appaterno;
                txtApmaterno.Text = contacto.Apmaterno;
                txtEdad.Text = contacto.Edad;
                txtEmail.Text = contacto.Email;
                txtTelefono.Text = contacto.Telefono;
                MessageBox.Show("Contacto encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            agenda.Eliminar(txtTelefono.Text);
            MessageBox.Show("Contacto Eliminado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtTelefono.Clear();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            txtListar.Text = agenda.Listar();
        }

        private void cmdEiminarinicio_Click(object sender, EventArgs e)
        {
            agenda.EliminarP();
        }

        private void cmdEliminarultimo_Click(object sender, EventArgs e)
        {
            agenda.EliminarU();
        }

        private void cmdReporteinverso_Click(object sender, EventArgs e)
        {
            txtListar.Text = agenda.ReporteInv();
        }

        private void cmdInvertirlista_Click(object sender, EventArgs e)
        {
            agenda.Invertir();
        }
    }
}
