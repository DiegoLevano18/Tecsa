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
    public class Negocio_UserWebP
    {

        Datos_UserWebP datos = new Datos_UserWebP();

        public DataTable Vista_UserWebP()
        {
            return datos.Vista_UserWebP();
        }

        public string Crear_UserWebP(UserWebP oUserWebP)
        {
            return datos.Crear_UserWebP(oUserWebP);
        }

        public string Actualizar_UserWebP(UserWebP oUserWebP)
        {
            return datos.Actualizar_UserWebP(oUserWebP);
        }

        public DataTable Buscar_UserWebP(int Id)
        {
            return datos.Buscar_UserWebP(Id);
        }

        public int Eliminar_UserWebP(int Id)
        {
            return datos.Eliminar_UserWebP(Id);
        }

    }
}
