using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class UserSistema
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public int IdEmpleado { get; set; }
    }
}
