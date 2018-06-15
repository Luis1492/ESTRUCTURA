using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_enlazadas_dobles
{
    class Contacto
    {
        private string nombre= "", appaterno, apmaterno, telefono, edad, email;

        private Contacto _siguiente;
        private Contacto _anterior;
        /// <summary>
        /// Estos son propiedades 
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Appaterno
        {
            get { return appaterno; }
            set { appaterno = value; }
        }

        public string Apmaterno
        {
            get { return apmaterno; }
            set { apmaterno = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Contacto Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
        public Contacto Anterior
        {
            get { return _anterior; }
            set { _anterior = value; }
        }
        public override string ToString()
        {
            return "Nombre: " + Nombre + " " + Appaterno + " " + Apmaterno + "Telefono: " + Telefono + "Edad: " + Edad + "Email: " + Email;
        }
    }
}

