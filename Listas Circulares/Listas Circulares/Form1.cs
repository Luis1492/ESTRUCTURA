using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_Circulares
{
    public partial class Form1 : Form
    {
        Ruta ruta = new Ruta();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            Base b = new Base(txtNombre.Text, int.Parse(txtMinutos.Text));
            ruta.Agregarfina(b);
            MessageBox.Show("Agregado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNombre.Clear();
            txtMinutos.Clear();
            comboxBases.Items.Add(b.Nombre);
        }

        private void cmdBusacr_Click(object sender, EventArgs e)
        {
            Base b = ruta.buscar(txtBuscar.Text);
            if (b == null)
            {
                MessageBox.Show("Base no Encontrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscar.Clear();

            }
            else
            {
                txtNombre.Text = b.Nombre;
                txtMinutos.Text = b.Minutos.ToString();
                MessageBox.Show("Base Encontrada", "Avisa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cmdElimianrP_Click(object sender, EventArgs e)
        {
            Base b = ruta.EliminarP();
            txtMostrar.Text = " Base Eliminada:" + Environment.NewLine + b.ToString();
            comboxBases.Items.Remove(b.Nombre);

        }

        private void cmdEliminarU_Click(object sender, EventArgs e)
        {
            Base b = ruta.EliminarrU();
            txtMostrar.Text = "Base Eliminada:" + Environment.NewLine + b.ToString();
            comboxBases.Items.Remove(b.Nombre);
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = ruta.Listar();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            Base b = ruta.Eliminar(txtNombre.Text);
            txtMostrar.Text = "Base Eliminada:" + Environment.NewLine + b.ToString();
            comboxBases.Items.Remove(b.Nombre);

        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            Base b = ruta.buscar(comboxBases.SelectedItem.ToString());
            txtMostrar.Text = ruta.ruta(b,dtpHoraI.Value, dtpHoraF.Value   );
        }

        private void cmdInserta_Click(object sender, EventArgs e)
        {
            Base b = new Base(txtNombre.Text, int.Parse(txtMinutos.Text));
            ruta.Insertar(b, int.Parse(txtInsertar.Text));
            MessageBox.Show("Insertado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        

        private void Form1_Load_1(object sender, EventArgs e)
        {
            /*dtpHoraI.Format = DateTimePickerFormat.Custom;
            dtpHoraI.CustomFormat = "hh:mm tt";
            dtpHoraF.Format = DateTimePickerFormat.Custom;
            dtpHoraF.CustomFormat = "hh:mm tt";
*/        }


    }
}
