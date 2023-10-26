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
    public class Negocio_RolOperaciones
    {

        Datos_RolOperaciones datos = new Datos_RolOperaciones();

        public DataTable Vista_RolOperaciones()
        {
            return datos.Vista_RolOperaciones();
        }

        public string Crear_RolOperaciones(RolOperaciones oRolOperaciones)
        {
            return datos.Crear_RolOperaciones(oRolOperaciones);
        }

        public string Actualizar_RolOperaciones(RolOperaciones oRolOperaciones)
        {
            return datos.Actualizar_RolOperaciones(oRolOperaciones);
        }

        public DataTable Buscar_RolOperaciones(int Id)
        {
            return datos.Buscar_RolOperaciones(Id);
        }

        public int Eliminar_RolOperaciones(int Id)
        {
            return datos.Eliminar_RolOperaciones(Id);
        }

    }
}
