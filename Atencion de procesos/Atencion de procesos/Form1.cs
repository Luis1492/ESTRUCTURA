﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencion_de_procesos
{
    public partial class Form1 : Form
    {
        Procesador procesador = new Procesador();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdProcesar_Click(object sender, EventArgs e)
        {
            txtmostrar.Text = procesador.procesar();
        }
    }
}
