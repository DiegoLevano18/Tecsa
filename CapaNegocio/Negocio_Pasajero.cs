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
    public class Negocio_Pasajero
    {

        Datos_Pasajero datos = new Datos_Pasajero();

        public DataTable Vista_Pasajero()
        {
            return datos.Vista_Pasajero();
        }

        public string Crear_Pasajero(Pasajero oPasajero)
        {
            return datos.Crear_Pasajero(oPasajero);
        }

        public string Actualizar_Pasajero(Pasajero oPasajero)
        {
            return datos.Actualizar_Pasajero(oPasajero);
        }

        public DataTable Buscar_Pasajero(int Id)
        {
            return datos.Buscar_Pasajero(Id);
        }

        public int Eliminar_Pasajero(int Id)
        {
            return datos.Eliminar_Pasajero(Id);
        }

    }
}
