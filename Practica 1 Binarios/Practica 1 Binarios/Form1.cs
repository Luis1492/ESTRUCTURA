using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Practica_1_Binarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         Int32 data(Int32 entero)
        {
            Int32 direc;
            direc = entero >>= 1;
            switch (direc & 7)
            {
                case 0:
                    picbdireccion .Image = Properties.Resources.norte;
                    lbldireccion.Text = "NORTE";
                    break;
                case 1:
                    picbdireccion.Image = Properties.Resources.noreste;
                    lbldireccion.Text = "NORESTE";
                    break;
                case 2:
                    picbdireccion.Image = Properties.Resources.este;
                    lbldireccion.Text = "ESTE";
                    break;
                case 3:
                    picbdireccion.Image = Properties.Resources.sureste;
                    lbldireccion.Text = "SURESTE";
                    break;
                case 4:
                    picbdireccion.Image = Properties.Resources.sur;
                    lbldireccion.Text = "SUR";
                    break;
                case 5:
                    picbdireccion.Image = Properties.Resources.suroeste;
                    lbldireccion.Text = "SUROESTE";
                    break;
                case 6:
                    picbdireccion.Image = Properties.Resources.oeste;
                    lbldireccion.Text = "OESTE";
                    break;
                case 7:
                    picbdireccion.Image = Properties.Resources.noroeste;
                    lbldireccion.Text = "NOROESTE";
                    break;

            }

            direc >>= 3;

            switch (direc & 3 )
            {
                case 0:
                    picbtanque.Image = Properties.Resources.vacio;
                    break;
                case 1:
                    picbtanque.Image = Properties.Resources.medio;
                    break;
                case 2:
                    picbtanque.Image = Properties.Resources.lleno;
                    break;
                case 3:
                    picbtanque.Image = Properties.Resources.llenandose;
                    lblllenadnose.Text = "PROCESO DE LLENADO";
                    break;
            }

            direc >>= 2;
            switch (direc & 1)
            {
                case 0:
                    picbsensor2.Image = Properties.Resources.apagado;
                    break;
                case 1:
                    picbsensor2.Image = Properties.Resources.encendido;
                    break;
            }
            direc >>= 1;
            switch(direc & 1)
            {
                case 0:
                    picbsensor1.Image = Properties.Resources.apagado;
                    break;
                case 1:
                    picbsensor1.Image = Properties.Resources.encendido;
                    break;
            }

            direc >>= 1;
            Int32 dia = direc & 31;

            direc >>= 5;
            Int32 mes = direc & 15;

            direc >>= 4;
            Int32 año = direc & 127;
  
            año += 1900;
            lblnuevafch.Text = año + "/" + mes + "/" + dia; 
            return direc;

        }

        private void cmdprocesar_Click(object sender, EventArgs e)
        {
            Int32 calcula = data(Convert.ToInt32(txtentrada.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
