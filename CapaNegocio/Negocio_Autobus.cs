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
    public class Negocio_Autobus
    {

        Datos_Autobus datos = new Datos_Autobus();

        public DataTable Vista_Autobus()
        {
            return datos.Vista_Autobus();
        }

        public string Crear_Autobus(Autobus oAutobus)
        {
            return datos.Crear_Autobus(oAutobus);
        }

        public string Actualizar_Autobus(Autobus oAutobus)
        {
            return datos.Actualizar_Autobus(oAutobus);
        }

        public DataTable Buscar_Autobus(int Id)
        {
            return datos.Buscar_Autobus(Id);
        }

        public int Eliminar_Autobus(int Id)
        {
            return datos.Eliminar_Autobus(Id);
        }

    }
}
