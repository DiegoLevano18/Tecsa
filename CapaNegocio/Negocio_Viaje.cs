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
    public class Negocio_Viaje
    {

        Datos_Viaje datos = new Datos_Viaje();

        public DataTable Vista_Viaje()
        {
            return datos.Vista_Viaje();
        }

        public string Crear_Viaje(Viaje oViaje)
        {
            return datos.Crear_Viaje(oViaje);
        }

        public string Actualizar_Viaje(Viaje oViaje)
        {
            return datos.Actualizar_Viaje(oViaje);
        }

        public DataTable Buscar_Viaje(int Id)
        {
            return datos.Buscar_Viaje(Id);
        }

        public int Eliminar_Viaje(int Id)
        {
            return datos.Eliminar_Viaje(Id);
        }

    }
}
