using AgendaTelefonica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonicaTest
{
    class DirectorioMock
    {
        public Directorio ObtenerDirectorioVacio()
        {
            return new Directorio();
        }

        public Directorio ObtenerDirectorioLleno()
        {
            int capacidad = 10;
            var directorio = new Directorio(capacidad);
            PoblarDirectorio(directorio, capacidad);
            return directorio;
        }

        public Directorio ObtenerDirectorio(int capacidad, int cantidadContactos)
        {
            var directorio = new Directorio(capacidad);
            PoblarDirectorio(directorio, cantidadContactos);
            return directorio;
        }

        public void PoblarDirectorio(Directorio directorio, int cantidad)
        {
            Contacto contacto;
            for (int i = 1; i <= cantidad; i++)
            {
                contacto = GenerarContactoAleatorio();
                directorio.AdicionarContacto(contacto);
            }
        }

        public Contacto GenerarContactoAleatorio()
        {
            return new Contacto()
            {
                Nombre = Guid.NewGuid().ToString(),
                Telefono = "12",
                Celular = "asas"
            };
        }
    }
}
