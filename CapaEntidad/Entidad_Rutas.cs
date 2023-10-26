using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Rutas
    {
        public int Id { get; set; }
        public string NombreRuta { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public int IdUserSistema { get; set; }
    }
}
