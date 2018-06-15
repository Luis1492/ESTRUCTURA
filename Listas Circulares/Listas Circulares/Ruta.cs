using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Circulares
{
    class Ruta
    {
        Base inicio, fin, aux;
        public void Agregarfina(Base b)
        {
            if(inicio == null)
            {
                inicio = b;
                inicio.Siguiente = b;
                inicio.Anterior = b;
                fin = b;
            }
            else
            {
                fin.Siguiente = b;
                b.Anterior = fin;
                b.Siguiente = inicio;
                inicio.Anterior = b;
                fin = b;
            }
        }
        public Base buscar(string n)
        {
            aux = inicio.Siguiente;
            if (inicio.Siguiente != inicio)
            {
                if (inicio.Nombre == n)
                {
                    return inicio;
                }
                else
                {
                    while(aux != inicio)
                    {
                        if (aux.Nombre == n)
                        {
                            return aux;
                        }
                        else
                        {
                            aux = aux.Siguiente;
                        }
                    }
                }
            }
            return null;

        }

    public Base EliminarrU()
        {
            Base Eliminada = fin;
            aux = inicio;
            aux.Anterior = fin.Anterior;
            fin.Anterior.Siguiente = inicio;
            fin = fin.Anterior;
            return Eliminada;
        }
        public Base EliminarP()
        {
            Base Elminada = inicio;
            aux = inicio;
            fin.Siguiente = aux.Siguiente;
            aux.Siguiente.Anterior = fin;
            inicio = aux.Siguiente;
            return Elminada;
        }
        public Base Eliminar(string n)
        {
            Base Eliminar;
            aux = inicio.Siguiente;
            if (inicio.Nombre ==n)
            {
                Eliminar = inicio;
                EliminarP();
                return Eliminar;
            }
            else
            {
                while (aux != inicio)
                {
                    if (aux.Nombre == n)
                    {
                        Eliminar = aux;
                        if (aux == fin)
                        {
                            EliminarrU();
                        }
                        else
                        {
                            aux.Anterior.Siguiente = aux.Siguiente;
                            aux.Siguiente.Anterior = aux.Anterior;
                        }
                        return Eliminar;
                    }
                    else aux = aux.Siguiente;
                }
            }
            return null;
        }
        public string Listar()
        {
            aux = inicio.Siguiente;
            string cadena = string.Format("{0,-20} {1,-15}", "Base", "Minutos");
            cadena += Environment.NewLine + inicio.ToString() + Environment.NewLine;

            while (aux != inicio)
            {
                cadena += aux.ToString() + Environment.NewLine;
                aux = aux.Siguiente;
            }
            return cadena;
        }
        public void Insertar(Base b, int p)
        {
            aux = inicio;
            for(int i =0; i <p-1; p++)
            {
                b.Siguiente = aux;
                b.Anterior = aux.Anterior;
                aux.Anterior = b;
                b.Anterior.Siguiente = b;
                if (p == 1)
                {
                    inicio = b;
                }
            }
        }
        public string ruta(Base b, DateTime Horai, DateTime Horaf)
        {
            string cadena = "";
            aux = inicio;
            while (aux.Nombre!=b.Nombre)
            {
                aux = aux.Siguiente;
            }
            cadena += "Base" + "Hora" + Environment.NewLine + aux.Nombre + "  " + Horai.Hour + ":" + Horai.Minute + Environment.NewLine;
            while (Horai < Horaf)
            {
                cadena += aux.Nombre + "   " + Horai.Hour + ":" + Horai.Minute + Environment.NewLine;
                aux = aux.Siguiente;
                Horai = Horai.AddMinutes(aux.Minutos);
                
            }
            return cadena;
        }
    }
}

