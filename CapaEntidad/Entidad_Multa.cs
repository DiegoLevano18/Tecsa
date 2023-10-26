using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Multa
    {
        public int Id { get; set; }
        public string Motivo { get; set; }
        public string Descripcion { get; set; }
        public TimeSpan Hora { get; set; }
        public DateTime Fecha { get; set; }
        public int IdConductor { get; set; }

    }
}
