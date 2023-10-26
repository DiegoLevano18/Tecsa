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
    public class Negocio_DetalleCB
    {

        Datos_DetalleCB datos = new Datos_DetalleCB();

        public DataTable Vista_DetalleCB()
        {
            return datos.Vista_DetalleCB();
        }

        public string Crear_DetalleCB(DetalleCB oDetalleCB)
        {
            return datos.Crear_DetalleCB(oDetalleCB);
        }

        public string Actualizar_DetalleCB(DetalleCB oDetalleCB)
        {
            return datos.Actualizar_DetalleCB(oDetalleCB);
        }

        public DataTable Buscar_DetalleCB(int Id)
        {
            return datos.Buscar_DetalleCB(Id);
        }

        public int Eliminar_DetalleCB(int Id)
        {
            return datos.Eliminar_DetalleCB(Id);
        }

    }
}
