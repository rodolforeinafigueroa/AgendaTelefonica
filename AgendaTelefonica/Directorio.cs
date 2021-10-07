using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    public class Directorio
    {
        private readonly Contacto[] contactos;
        private bool directorioLLeno;
        private int posicionLibre;

        private List<Contacto> contactosReales
        {
            get {  return (from contacto in contactos
                          where contacto != null
                          select contacto).ToList(); } 
        }

        public Directorio() : this(10)
        {
        }

        public Directorio(int nroContactos)
        {
            directorioLLeno = false;
            contactos = new Contacto[nroContactos];
        }

        public void AdicionarContacto(Contacto contacto)
        {
            if (directorioLLeno)
            {
                throw new DirectorioLlenoException("No es posible adicionar el contacto, ya el directorio esta lleno");

            }
            if (ExisteContacto(contacto))
            {
                throw new ContactoYaExisteException("El contacto que desea adicionar ya existe en el directorio");
            }
            contactos[posicionLibre] = contacto;
            ActualizarDirectorioLleno();
        }

        private void ActualizarDirectorioLleno()
        {
            directorioLLeno = true;
            posicionLibre = 0;
            foreach (Contacto contacto in contactos)
            {
                if (contacto == null)
                {
                    directorioLLeno = false;
                    break;
                }
                posicionLibre ++;
            }
        }

        public bool ExisteContacto(Contacto contacto)
        {
            var contactoEncontrado = BuscarContacto(contacto.Nombre);
            return contactoEncontrado != null;
        }

        public void ListarContactos()
        {
            foreach (Contacto contacto in contactosReales)
            {
                Console.WriteLine(contacto.MostrarInformacion());
            }
        }

        public Contacto? BuscarContacto(string nombre)
        {
            foreach (Contacto contacto in contactosReales)
            {
                if (contacto.Nombre.Equals(nombre))
                {
                    return contacto;
                }
            }

            return null;
        }

        public void EliminarContacto(Contacto contacto)
        {
            var posicionContacto = ObtenerPosicionContacto(contacto.Nombre);
            if (posicionContacto == -1)
            {
                Console.WriteLine("El contacto que intenta eliminar no existe");
            }
            contactos[posicionContacto] = null;
            ActualizarDirectorioLleno();
        }

        private int ObtenerPosicionContacto(string nombre)
        {
            int posicion = -1;
            foreach (Contacto contacto in contactos)
            {
                if (contacto.Nombre.Equals(nombre))
                {
                    break;
                }
            }
            return posicion;
        }

        public bool DirectorioLLeno()
        {
            return directorioLLeno;
        }

       



    }
}
