using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonicaTest
{
    [TestClass]
    public class ListarContactos
    {
        private readonly DirectorioMock directorioMock;

        public ListarContactos()
        {
            directorioMock = new DirectorioMock();
        }

        [TestMethod]
        public void ListarContactosSinErrores()
        {
            var Directorio = directorioMock.ObtenerDirectorio(10, 5);
            Directorio.ListarContactos();
        }
    }
}
