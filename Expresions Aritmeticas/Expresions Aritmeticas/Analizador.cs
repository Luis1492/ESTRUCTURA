using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expresions_Aritmeticas
{
    class Analizador
    {
        Nodo inicio, aux;
        public void Agregarf(Nodo n)
        {
            if (inicio == null)
            {
                inicio = n;
            }
            else
            {
                Agregar(inicio, n);
            }
        }
        public void Agregar(Nodo a, Nodo n)
        {
            if (a.Siguiente == null)
            {
                a.Siguiente = n;
                n.Anterior = a;
            }
            else
            {
                Agregar(a.Siguiente, n);
            }
        }
        private void Arbol(Nodo Raiz)
        {
            Raiz.Izquierda = Raiz.Anterior;
            Raiz.Derecha = Raiz.Siguiente;
            Raiz.Anterior = Raiz.Anterior.Anterior;
            if (Raiz.Izquierda == inicio)
            {
                inicio = Raiz;
            }
            else
            {
                Raiz.Anterior.Siguiente = Raiz;
            }
            Raiz.Siguiente = Raiz.Siguiente.Siguiente;
            if (Raiz.Siguiente != null)
            {
                Raiz.Siguiente.Anterior = Raiz;
            }
        }
        public string Analizar()
        {
            aux = inicio;
            string pre = "", post = "";
            while (aux != null)
            {
                string c = aux.ToString();
                if(c=="/" || c == "*")
                {
                    Arbol(aux);
                }
                aux = aux.Siguiente;
            }
            aux = inicio;
            while (aux != null)
            {
                string c = aux.ToString();
                if(c=="+" || c == "-")
                {
                    Arbol(aux);
                }
                aux = aux.Siguiente;
            }
            preOrder(inicio, ref pre);
            postOrder(inicio, ref post);
            return "PreOrden: " + pre + Environment.NewLine + "PstOrden: " + post;

        }
        private void preOrder(Nodo p, ref string cadena)
        {
            if (p != null)
            {
                cadena += p.ToString() + " ";
                preOrder(p.Izquierda, ref cadena);
                preOrder(p.Derecha, ref cadena);
            }
        }
        private void postOrder(Nodo p, ref string cadena)
        {
            if (p != null)
            {
                postOrder(p.Izquierda, ref cadena);
                postOrder(p.Derecha, ref cadena);
                cadena += p.ToString() + " ";
            }
        }
    }
}
