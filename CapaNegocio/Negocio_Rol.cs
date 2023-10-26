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
    public class Negocio_Rol
    {

        Datos_Rol datos = new Datos_Rol();

        public DataTable Vista_Rol()
        {
            return datos.Vista_Rol();
        }

        public string Crear_Rol(Rol oRol)
        {
            return datos.Crear_Rol(oRol);
        }

        public string Actualizar_Rol(Rol oRol)
        {
            return datos.Actualizar_Rol(oRol);
        }

        public DataTable Buscar_Rol(int Id)
        {
            return datos.Buscar_Rol(Id);
        }

        public int Eliminar_Rol(int Id)
        {
            return datos.Eliminar_Rol(Id);
        }

    }
}
