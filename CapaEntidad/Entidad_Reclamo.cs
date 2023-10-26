using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Reclamo
    {
        public int Id { get; set; }
        public string Motivo { get; set; }
        public int IdViaje { get; set; }
        public int IdUserWebP { get; set; }
        public DateTime FechaR { get; set; }
        public string Detalles { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
    }
}
