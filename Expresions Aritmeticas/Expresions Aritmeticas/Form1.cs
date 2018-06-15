using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expresions_Aritmeticas
{
    public partial class Form1 : Form
    {
        Analizador analizador = new Analizador();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdanalizar_Click(object sender, EventArgs e)
        {
            
            string[] vec = txtexpresion.Text.Split(' ');
            foreach(string s in vec)
            {
                Nodo a = new Nodo(s);
                analizador.Agregarf(a);
            }
            txtmostrar.Text = analizador.Analizar();
            txtexpresion.Clear();
        }
    }
}
