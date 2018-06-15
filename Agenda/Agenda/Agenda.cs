using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Agenda
    {
        Contactos[] contactos = new Contactos[15];
        public int contador = 0;
        public int total = 14;
        public void Agregar(Contactos info)
        {
            bool bandera = false;
            if(contador == 0)
            {
                contactos[contador] = info;
                contador++;
            }
            else
            {
                for(int m =contador-1; m>=0 && bandera != true; m--)
                {
                    if (int.Parse(info.Telefono) > int.Parse(contactos[m].Telefono))
                    {
                        for(int x=contador; x>m+1; x--)
                        {
                            contactos[x] = contactos[x-1];
                        }
                        contactos[m + 1] = info;
                        bandera = true;
                    }
                }
                contador++;
            }
        }

        public Contactos Buscar(string tel)
        {
            bool bandera = false;
            for(int b=0; b<total || bandera !=true; b++)
            {
                if(int.Parse(tel) >= int.Parse(contactos[b].Telefono))
                {
                    if(contactos[b].Telefono == tel)
                    {
                        return contactos[b];
                    }
                }
                else
                {
                    bandera = true;
                }
            }
            return null;
        }   

        public void Eliminar(string tel)
        {
            bool bandera = false;
            for(int e=0; e<total || bandera!=true; e--)
            {
                if(int.Parse(tel) > int.Parse(contactos[e].Telefono))
                {
                    if(contactos[e].Telefono== tel)
                    {
                        for (int x = e; x < contador - 1; x++)
                        {
                            contactos[x] = contactos[x + 1];
                        }
                    }
                }
                else
                {
                    bandera = true;
                }
            }
            contactos[contador - 1] = null;
            contador--;
        }

        public string Listar()
        {
            string cadena = " ";
            for(int m=0; m < contador; m++)
            {
                cadena += contactos[m].Nombre + " " + contactos[m].Appaterno + " " +  contactos[m].Apmaterno + Environment.NewLine + contactos[m].Telefono + Environment.NewLine + contactos[m].Edad + Environment.NewLine + contactos[m].Email + Environment.NewLine;

            }
            return cadena;
        }
    }
}
