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
    public class Negocio_Operaciones
    {

        Datos_Operaciones datos = new Datos_Operaciones();

        public DataTable Vista_Operaciones()
        {
            return datos.Vista_Operaciones();
        }

        public string Crear_Operaciones(Operaciones oOperaciones)
        {
            return datos.Crear_Operaciones(oOperaciones);
        }

        public string Actualizar_Operaciones(Operaciones oOperaciones)
        {
            return datos.Actualizar_Operaciones(oOperaciones);
        }

        public DataTable Buscar_Operaciones(int Id)
        {
            return datos.Buscar_Operaciones(Id);
        }

        public int Eliminar_Operaciones(int Id)
        {
            return datos.Eliminar_Operaciones(Id);
        }

    }
}
