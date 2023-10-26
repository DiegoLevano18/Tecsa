using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Negocio_Conductor
    {

        Datos_Conductor datos = new Datos_Conductor();

        public DataTable Vista_Conductor()
        {
            return datos.Vista_Conductor();
        }

        public string Crear_Conductor(Conductor oConductor)
        {
            return datos.Crear_Conductor(oConductor);
        }

        public string Actualizar_Conductor(Conductor oConductor)
        {
            return datos.Actualizar_Conductor(oConductor);
        }

        public DataTable Buscar_Conductor(int Id)
        {
            return datos.Buscar_Conductor(Id);
        }

        public int Eliminar_Conductor(int Id)
        {
            return datos.Eliminar_Conductor(Id);
        }

    }
}
