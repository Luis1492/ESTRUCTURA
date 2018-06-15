using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_enlazadas_dobles
{
    class Agenda
    {
        private Contacto inicio, aux;

        public void agregar(Contacto nuevo, string telefono)
        {
            int tel = int.Parse(telefono);
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                if (tel < int.Parse(inicio.Telefono))
                {
                    aux = inicio;
                    inicio = nuevo;
                    aux.Anterior = inicio;
                    inicio.Siguiente = aux;
                }
                else
                {
                    agregar(nuevo, inicio, tel);
                }
            }
            
        }
        public void agregar(Contacto nuevo, Contacto n, int tel)
        {
            if (n == null)
            {
                aux.Siguiente = nuevo;
                nuevo.Anterior = aux;
            }
            else
            {
                if (int.Parse(n.Telefono) > tel)
                {
                    nuevo.Anterior = n.Anterior;
                    nuevo.Siguiente = n;
                    n.Anterior.Siguiente = nuevo;
                    n.Anterior = nuevo;
                }
                else
                {
                    aux = n;
                    agregar(nuevo, n.Siguiente, tel);
                }
            }
        }
        public Contacto Buscar(string telefono)
        {
            aux = inicio;
            int tel = int.Parse(telefono);
            bool bandera = false;
            while (aux != null && bandera != true)
            {
                if (int.Parse(aux.Telefono) >= tel)
                {
                    bandera = true;
                    if (int.Parse(aux.Telefono) == tel)
                    {
                        return aux;
                    }
                }
                aux = aux.Siguiente;
            }
            return null;
        }
        public void Eliminar(string telefono)
        {
            int tel = int.Parse(telefono);
            bool bandera = false;
            aux = inicio;
            if (aux.Telefono == telefono)
            {
                EliminarP();
            }
            else
            {
                while (aux != null && bandera != true)
                {
                    if (int.Parse(aux.Siguiente.Telefono) >= tel)
                    {
                        bandera = true;
                        if (int.Parse(aux.Siguiente.Telefono) == tel)
                        {
                            aux.Siguiente = aux.Siguiente.Siguiente;
                            aux.Siguiente.Anterior = aux;

                        }
                    }
                    aux = aux.Siguiente;
                }
            }
        }
        public void EliminarP()
        {
            if (inicio.Siguiente == null)
            {
                inicio = null;
            }
            else
            {
                inicio = inicio.Siguiente;
                inicio.Anterior = null;
            }
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
                while (aux.Siguiente != null)
                {
                    aux = aux.Siguiente;
                }
            }
            aux.Anterior.Siguiente = null;
        }
        public string Listar()
        {
            aux = inicio;
            string cadena = "";
            while (aux != null)
            {
                cadena += aux.ToString() + Environment.NewLine;
                aux = aux.Siguiente;
            }
            return cadena;
        }
    }
}