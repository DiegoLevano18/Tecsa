using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class LicenciaConducir
    {
        public int Id { get; set; }
        public string NumeroLicencia { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public string Categoria { get; set; }
        public string Clase { get; set; }
    }
}
