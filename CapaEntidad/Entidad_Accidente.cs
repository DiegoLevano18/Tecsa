using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Accidente
    {
        public int Id { get; set; }
        public int IdAutobus { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Causa { get; set; }
        public string Ubicacion { get; set; }
        public string Gravedad { get; set; }
        public string tipo { get; set; }

    }
}
