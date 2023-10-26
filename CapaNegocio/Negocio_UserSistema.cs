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
    public class Negocio_UserSistema
    {

        Datos_UserSistema datos = new Datos_UserSistema();

        public DataTable Vista_UserSistema()
        {
            return datos.Vista_UserSistema();
        }

        public string Crear_UserSistema(UserSistema oUserSistema)
        {
            return datos.Crear_UserSistema(oUserSistema);
        }

        public string Actualizar_UserSistema(UserSistema oUserSistema)
        {
            return datos.Actualizar_UserSistema(oUserSistema);
        }

        public DataTable Buscar_UserSistema(int Id)
        {
            return datos.Buscar_UserSistema(Id);
        }

        public int Eliminar_UserSistema(int Id)
        {
            return datos.Eliminar_UserSistema(Id);
        }

    }
}
