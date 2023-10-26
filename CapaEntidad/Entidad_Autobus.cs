using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Autobus
    {
        public int Id { get; set; }
        public string NPlaca { get; set; }
        public int NAsientos { get; set; }
        public int CapacidadP { get; set;}
        public string Estado { get; set; }
        public string Observaciones { get; set; }
    }
}
