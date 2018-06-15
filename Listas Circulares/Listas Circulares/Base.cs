using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Circulares
{
    class Base
    {
        string nombre;
        int minutos;
        Base _siguiente, _anterior;

        public Base(string nuevo, int minut)
        {
            nombre = nuevo;
            minutos = minut;
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public int Minutos
        {
            get { return minutos; }
        }
        public Base Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
        public Base Anterior
        {
            get { return _anterior; }
            set { _anterior = value; }
        }

        public override string ToString()
        {
            return string.Format("{0,-20} {1,-15}", Nombre, Minutos);
        }
    }
}
