using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_enlazadas_new
{
    class Agenda
    {
        public int contador = 0;
        public Datos inicio, aux;

        public void AgregarInicio(Datos n)
        {
            if (inicio == null)
            {
                inicio = n;
                contador++;
            }
            else
            {
                Agregar(n, inicio);
            }
        }
        public void EliminarP()
        {
            if(inicio.Siguiente== null)
            {
                inicio = null;
            }
            else
            {
                inicio = inicio.Siguiente;
            }
            contador--;
        }
        public void EliminarU()
        {
            aux = inicio;
            if (aux.Siguiente == null)
            {
                aux = null;
            }
            else
            {
                while (aux != null)
                {
                    if (aux.Siguiente.Siguiente == null)
                    {
                        aux.Siguiente = null;
                    }
                    aux = aux.Siguiente;
                }
            }
            contador--;
        }
        public string ReporteInv()
        {
            string cadena = "";
            if(inicio.Siguiente == null)
            {
                return cadena;
            }
            else
            {
                int c = contador;
                while (c != 0)
                {
                    aux = inicio;
                    for (int e= 0; e<c-1; e++)
                    {
                        aux = aux.Siguiente;
                    }
                    cadena += aux.ToString() + Environment.NewLine;
                    c--;
                }
            }
            return cadena;
        }
        public void Invertir()
        {
            Datos InicioN = null, Ultimo = inicio   ;
            int c = contador;
            while (c != 0)
            {
                aux = inicio;
                Datos siguiente = null;
                for (int i = 0; i < c - 1; i++)
                {
                    aux = aux.Siguiente;
                    if (i == contador - 2)
                    {
                        InicioN = aux;
                    }
                    if (i == c - 3)
                    {
                        siguiente = aux;
                    }
                    if (c == 2)
                    {
                        siguiente = Ultimo;
                    }
                }
                aux.Siguiente = siguiente;
                c--;
            }
            inicio = InicioN;
        }

        public void Agregar(Datos info, Datos a)
        {
           
            if (a.Siguiente==null)
            {
                a.Siguiente= info;
                contador++;
            }
            else
            {
                Agregar(info, a.Siguiente);
            }
        }

        public Datos Buscar(string tel)
        {
            aux = inicio;
            while (aux != null)
            {
                if (aux.Telefono == tel)
                {
                    return aux;
                }
                aux = aux.Siguiente;
            }
            return null;
        }

        public void Eliminar(string tel)
        {
            bool bandera = false;
            aux = inicio;

            if(aux.Telefono == tel)
            {
                EliminarP();
            }
            else
            {
                while (aux != null && bandera != true)
                {
                    if (aux.Siguiente.Telefono == tel)
                    {
                        aux.Siguiente = aux.Siguiente.Siguiente;
                        bandera = true;
                        contador--;
                    }
                    aux = aux.Siguiente;
                }

            }
            
        }

        public string Listar()
        {
            aux = inicio;
            string cadena = " ";
            while (aux != null)
            {
                cadena += aux.ToString() + Environment.NewLine;
                aux = aux.Siguiente;    
            }
            return cadena;
        }
    }
}
