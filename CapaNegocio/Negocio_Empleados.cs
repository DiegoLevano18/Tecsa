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
    public class Negocio_Empleado
    {

        Datos_Empleado datos = new Datos_Empleado();

        public DataTable Vista_Empleado()
        {
            return datos.Vista_Empleado();
        }

        public string Crear_Empleado(Empleado oEmpleado)
        {
            return datos.Crear_Empleado(oEmpleado);
        }

        public string Actualizar_Empleado(Empleado oEmpleado)
        {
            return datos.Actualizar_Empleado(oEmpleado);
        }

        public DataTable Buscar_Empleado(int Id)
        {
            return datos.Buscar_Empleado(Id);
        }

        public int Eliminar_Empleado(int Id)
        {
            return datos.Eliminar_Empleado(Id);
        }

    }
}
