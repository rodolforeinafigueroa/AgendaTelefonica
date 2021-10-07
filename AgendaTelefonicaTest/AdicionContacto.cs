using AgendaTelefonica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AgendaTelefonicaTest
{
    [TestClass]
    public class AdicionContacto
    {
        private readonly DirectorioMock directorioMock;

        public AdicionContacto()
        {
            directorioMock = new DirectorioMock();
        }

        [TestMethod]
        public void DebeAdicionarContactoSinError()
        {
            var Directorio = directorioMock.ObtenerDirectorioVacio();
            var Contacto = new Contacto()
            {
                Nombre = "Rodolfo Reina Figueroa",
                Telefono = "3803302",
                Celular = "3163070156"
            };

            Directorio.AdicionarContacto(Contacto);

        }

        [TestMethod]
        [ExpectedException(typeof(DirectorioLlenoException),
                "No es posible adicionar el contacto, ya el directorio esta lleno")]
        public void DebeAdicionarContactoConErrorDiccionarioLleno()
        {
            var Directorio = directorioMock.ObtenerDirectorioLleno();
            var Contacto = new Contacto()
            {
                Nombre = "Rodolfo Reina Figueroa",
                Telefono = "3803302",
                Celular = "3163070156"
            };

            Directorio.AdicionarContacto(Contacto);

        }

        [TestMethod]
        [ExpectedException(typeof(ContactoYaExisteException),
                "El contacto que desea adicionar ya existe en el directorio")]
        public void DebeSalirErrorPorqueYaExiste()
        {
            var Directorio = directorioMock.ObtenerDirectorioVacio();
            var Contacto = new Contacto()
            {
                Nombre = "Rodolfo Reina Figueroa",
                Telefono = "3803302",
                Celular = "3163070156"
            };

            var Contacto2 = new Contacto()
            {
                Nombre = "Rodolfo Reina Figueroa",
                Telefono = "3803302",
                Celular = "3163070156"
            };

            Directorio.AdicionarContacto(Contacto);
            Directorio.AdicionarContacto(Contacto2);

            

        }
    }
}