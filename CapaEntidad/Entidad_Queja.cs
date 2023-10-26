using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Queja
    {
        public int Id { get; set; }
        public TimeSpan Hora { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int IdUserWebP { get; set; }
    }
}
