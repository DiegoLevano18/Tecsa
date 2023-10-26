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
    public class Negocio_UserWebC
    {

        Datos_UserWebC datos = new Datos_UserWebC();

        public DataTable Vista_UserWebC()
        {
            return datos.Vista_UserWebC();
        }

        public string Crear_UserWebC(UserWebC oUserWebC)
        {
            return datos.Crear_UserWebC(oUserWebC);
        }

        public string Actualizar_UserWebC(UserWebC oUserWebC)
        {
            return datos.Actualizar_UserWebC(oUserWebC);
        }

        public DataTable Buscar_UserWebC(int Id)
        {
            return datos.Buscar_UserWebC(Id);
        }

        public int Eliminar_UserWebC(int Id)
        {
            return datos.Eliminar_UserWebC(Id);
        }

    }
}
