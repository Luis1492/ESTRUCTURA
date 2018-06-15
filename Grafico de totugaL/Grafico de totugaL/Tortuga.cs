using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafico_de_totugaL
{
    class Tortuga
    {
        private int[,] grafico = new int[20, 20];
        bool pluma;
        int d, i, direccion; //arriba, abajo, derecha, izquierda

        public Tortuga()
        {
            pluma = false;
            direccion = 2;
            d = 0;
            i = 0;
        }
        public void Subir_pluma()
        {
            pluma = false;

        }
         public void Bajar_pluma()
         {
            pluma = true;
            grafico[d, i] = 1;
         }
        public void girar_derecha()
        {
            if (direccion == 1)
            {
                direccion = 2;
            }
            else
            {
                if (direccion == 2)
                {
                    direccion = 3;
                }
                else
                {
                    if (direccion == 3)
                    {
                        direccion = 4;
                    }
                    else
                    {
                        direccion = 1;
                    }
                }
            }

        }
         public void girar_izquierda()
         {
            if (direccion == 1)
            {
                direccion = 4;
            }
            else
            {
                if (direccion == 4)
                {
                    direccion = 3;
                }
                else
                {
                    if (direccion == 3)
                    {
                        direccion = 2;
                    }
                    else
                    {
                        direccion = 1;
                    }
                }
            }
         }
         public void avanza(int pasos)
         {
            if (direccion == 2 && (i + pasos) <= 19)
            {
                if (pluma == true)
                {
                    for (int a = i; a <= (i+pasos); a++)
                    {
                        grafico[d, a] = 1;
                    }
                    i += pasos;
                }

            }
            if(direccion==1 && (d-pasos) >= 0)
            {
                if (pluma == true)
                {
                    for(int a=d; a >= (d-pasos); a--)
                    {
                        grafico[a, i] = 1;
                    }
                    d -= pasos;
                }
            }
            if(direccion==3 && (d +pasos) <= 19)
            {
                if (pluma == true)
                {
                    for(int a = d; a<= (d+ pasos); a++)
                    {
                        grafico[a, i] = 1;
                    }
                    d += pasos;
                }
            }
            if (direccion == 4 && (i - pasos) >=0)
            {
                if (pluma == true)
                {
                    for(int a=i; a>=(i-pasos); a--)
                    {
                        grafico[d, a] = 1;
                    }
                    i -= pasos;
                }
            }

         }
        public void Centinela()
        {
            for(int c=0; c<=20; c++)
            {
                for(int f=0; f <= 20; f++)
                {
                    grafico[c, f] = 0;
                }
            }
        }
        public override string ToString()
        {
            string cadena = "";
            for(int c=0; c<20; c++)
            {
                for(int f=0; f<20; f++)
                {
                    if (grafico[c, f] == 1)
                    {
                        cadena += "*";
                    }
                    else
                    {
                        cadena += "";
                    }
                    if (f==19)
                    {
                        cadena += Environment.NewLine;
                    }
                    else
                    {
                        cadena += " , ";
                    }
                }
            }
            return cadena;
        }

    }
}
