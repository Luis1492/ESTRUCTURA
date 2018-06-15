using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expresions_Aritmeticas
{
    class Nodo
    {
        Nodo _anterior, _siguiente, _izquierda, _derecha;
        string dato;
        public Nodo(string c)
        {
            dato = c;
        }
        public Nodo Anterior
        {
            get { return _anterior; }
            set { _anterior = value; }
        }
        public Nodo Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
        public Nodo Izquierda
        {
            get { return _izquierda; }
            set { _izquierda = value; }
        }
        public Nodo Derecha
        {
            get { return _derecha; }
            set { _derecha = value; }
        }
        public override string ToString()
        {
            return dato;
        }
    }
}
