using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_enlazadas_dobles
{
    public partial class Form1 : Form
    {
        Agenda agenda = new Agenda();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            Contacto a = new Contacto();
            a.Nombre = txtNombre.Text;
            a.Appaterno = txtApepaterno.Text;
            a.Apmaterno = txtApmaterno.Text;
            a.Edad = txtEdad.Text;
            a.Telefono = txtTelefono.Text;
            a.Email = txtEmail.Text;
            agenda.agregar(a, txtTelefono.Text);
            MessageBox.Show("Contacto Agregado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            Clear();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Contacto contac = agenda.Buscar(txtTelefono.Text);
            if(contac == null)
            {
                MessageBox.Show("Contacto No Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
            }
            else
            {
                txtNombre.Text = contac.Nombre;
                txtApepaterno.Text = contac.Appaterno;
                txtApmaterno.Text = contac.Apmaterno;
                txtEdad.Text = contac.Edad;
                txtTelefono.Text = contac.Telefono;
                txtEmail.Text = contac.Email;
                MessageBox.Show("Contacto Encrontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            agenda.Eliminar(txtTelefono.Text);
            MessageBox.Show("Contacto Eliminado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
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
        public void Clear()
        {
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtApmaterno.Text = "";
            txtApepaterno.Text = "";
            txtEmail.Text = "";
            txtEdad.Text = "";
            txtNombre.Focus();
        }
    }
}
