using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    public class Contacto
    {
        public string Nombre {  get; set; } = string.Empty;
        public string Telefono {  get; set; } = string.Empty;
        public string Celular {  get; set; } = string.Empty;        
        internal string MostrarInformacion()
        {
            return $"- Nombre: {Nombre} - Telefono: {Telefono} - Celular: {Celular}";
        }
    }
}
