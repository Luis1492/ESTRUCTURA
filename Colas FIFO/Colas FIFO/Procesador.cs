using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_FIFO
{
    class Procesador
    {
        Proceso inicio, aux;
        static Random num = new Random();

        private void Agregarf(Proceso p)
        {
            if (inicio == null)
            {
                inicio = p;
            }
            else
            {
                agregar(p, inicio);
            }
        }
        private void agregar(Proceso n , Proceso a)
        {
            if (a.Siguiente == null)
            {
                a.Siguiente = n;

            }
            else
            {
                agregar(n, a.Siguiente);
            }
        }
        private void EliminarI()
        {
            if (inicio.Siguiente == null)
            {
                inicio = null;
            }
            else
            {
                inicio = inicio.Siguiente;
            }
        }
        public string Procesar()
        {
            int Ciclovacio = 0, Procesosrealizados = 0, Procesospendientes = 0, Ciclospendientes = 0;
            for(int c = 0; c < 300; c++)
            {
                int n = num.Next(1, 101);
                if (n <= 35)
                {
                    n = num.Next(4, 15);
                    aux = new Proceso(n);
                    Agregarf(aux);
                }
                if (inicio != null)
                {
                    inicio.Ciclos--;
                    if (inicio.Ciclos == 0)
                    {
                        EliminarI();
                        Procesosrealizados++;
                    }
                }
                else
                    Ciclovacio++;
            }
            aux = inicio;
            if (inicio != null)
            {
                Procesospendientes++;
                Ciclospendientes += aux.Ciclos;
                aux = aux.Siguiente;
            }
            return "Ciclos Vacios: " + Ciclovacio + Environment.NewLine + "Procesos Atendidos: " + Procesosrealizados + Environment.NewLine + "Procesos Pendientes: " + Procesospendientes + Environment.NewLine + "Ciclos Pendientes: " + Ciclospendientes;
        }

    }
}
