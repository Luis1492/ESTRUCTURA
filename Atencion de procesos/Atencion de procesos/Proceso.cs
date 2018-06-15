using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atencion_de_procesos
{
    class Proceso
    {
        Proceso _siguiente, _anterior;
        int ciclos;
        public Proceso(int c)
        {
            ciclos = c;
        }
        public int Ciclos
        {
            set { ciclos = value; }
            get { return ciclos; }
        }
        public Proceso Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
        public Proceso Anterior
        {
            get { return _anterior; }
            set { _anterior = value; }
        }

    }
}
