using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafico_de_totugaL
{
    public partial class Form1 : Form
    {
        Tortuga caguama = new Tortuga();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdPlumaArr_Click(object sender, EventArgs e)
        {
            caguama.Subir_pluma();
            txtgrafico.Clear();
        }

        private void cmdPlumaAba_Click(object sender, EventArgs e)
        {
            caguama.Bajar_pluma();
            txtgrafico.Clear();
        }

        private void cmdGiraD_Click(object sender, EventArgs e)
        {
            caguama.girar_derecha();
        }

        private void cmdGiraIz_Click(object sender, EventArgs e)
        {
            caguama.girar_izquierda();
        }

        private void cdmAvanza_Click(object sender, EventArgs e)
        {
            caguama.avanza(int.Parse(txtpasos.Text));
        }

        private void cdmImprime_Click(object sender, EventArgs e)
        {
            txtgrafico.Clear();
            txtgrafico.Text =caguama.ToString();
            
        }

        private void cdmCentinela_Click(object sender, EventArgs e)
        {
            caguama.Centinela();
        }
    }
}
