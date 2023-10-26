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
    public class Negocio_Rutas
    {

        Datos_Rutas datos = new Datos_Rutas();

        public DataTable Vista_Rutas()
        {
            return datos.Vista_Rutas();
        }

        public string Crear_Rutas(Rutas oRutas)
        {
            return datos.Crear_Rutas(oRutas);
        }

        public string Actualizar_Rutas(Rutas oRutas)
        {
            return datos.Actualizar_Rutas(oRutas);
        }

        public DataTable Buscar_Rutas(int Id)
        {
            return datos.Buscar_Rutas(Id);
        }

        public int Eliminar_Rutas(int Id)
        {
            return datos.Eliminar_Rutas(Id);
        }

    }
}
