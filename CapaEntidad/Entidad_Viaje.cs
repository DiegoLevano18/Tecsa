using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Viaje
    {
        public int Id { get; set; }
        public int CodigoViaje { get; set; }
        public string NombreViaje { get; set; }
        public float Costo { get; set; }
        public int IdRuta { get; set; }
        public int IdUserSistema { get; set; }
        public int IdDetalleCB { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
    }
}
