using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atencion_de_procesos
{
    class Procesador
    {
        Proceso aux, inicio, final, actual;
        static Random num = new Random();
        private void AgregarFin(Proceso p)
        {
            if (inicio == null)
            {
                inicio = p;
                final = p;
                inicio.Siguiente = final;
                inicio.Anterior = final;
                actual = inicio;
            }
            else
            {
                final.Siguiente = p;
                p.Siguiente = inicio;
                p.Anterior = final;
                inicio.Anterior = p;
                final = p;
            }
        }
        private void Eliminarinicio()
        {
            final.Siguiente = inicio.Siguiente;
            inicio.Siguiente.Anterior = final;
            inicio = inicio.Anterior;
        }
        private void Eliminarfinal()
        {
            inicio.Anterior = final.Anterior;
            final.Anterior.Siguiente = inicio;
            final = final.Anterior;
        }
        private void Eliminaractual()
        {
            if (actual == inicio)
            {
                Eliminarinicio();
            }
            else
            {
                if (actual == final)
                {
                    Eliminarfinal();
                }
                else
                {
                    actual.Anterior.Siguiente = actual.Siguiente;
                    actual.Siguiente.Anterior = actual.Anterior;
                }
            }
        }
        public string procesar()
        {
            int Ciclosvacias = 0, Procesospendientes = 0, Procesosrealizados = 0, Ciclospendiente = 0;
            for (int c = 0; c < 20; c++)
            {
                int n = num.Next(1, 101);
                if (n <= 5)
                {
                    n = num.Next(2, 8);
                    aux = new Proceso(n);
                    AgregarFin(aux);
                }
                if (inicio != null)
                {
                    actual.Ciclos--;
                    if (actual.Ciclos < 0)
                    {
                        n = 0;
                    }
                    if (actual.Ciclos == 0)
                    {
                        Eliminaractual();
                        Procesosrealizados++;
                    }
                    actual = actual.Siguiente;
                }
                else { Ciclosvacias++; }
            }
            aux = inicio;
            do
            {
                Procesospendientes++;
                Ciclospendiente += aux.Ciclos;
                aux = aux.Siguiente;
            } while (aux != inicio);
                return "Ciclos Vacios: " + Ciclosvacias + Environment.NewLine + "Procesos Pendientes: " + Procesospendientes + Environment.NewLine + "Ciclos Pendientes: " + Ciclospendiente + Environment.NewLine + "Procesos Realizados: " + Procesosrealizados;
        }
    }
}
