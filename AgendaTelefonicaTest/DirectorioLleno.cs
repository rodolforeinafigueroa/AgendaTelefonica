using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonicaTest
{
    [TestClass]
    public class DirectorioLleno
    {
        private readonly DirectorioMock directorioMock;

        public DirectorioLleno()
        {
            directorioMock = new DirectorioMock();
        }

        [TestMethod]
        public void DirectorioEstaLleno()
        {
            var Directorio = directorioMock.ObtenerDirectorioLleno();
            var directorioLLeno = Directorio.DirectorioLLeno();
            Assert.AreEqual(true, directorioLLeno);
        }

        [TestMethod]
        public void DirectorioVacio()
        {
            var Directorio = directorioMock.ObtenerDirectorioVacio();
            var directorioLLeno = Directorio.DirectorioLLeno();
            Assert.AreEqual(false, directorioLLeno);
        }

    }
}
