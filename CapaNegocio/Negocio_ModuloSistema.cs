using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class Negocio_ModuloSistema
    {

        Datos_ModuloSistema datos = new Datos_ModuloSistema();

        public DataTable Vista_ModuloSistema() 
        {
            return datos.Vista_ModuloSistema();
        }

        public string Crear_ModuloSistema(ModuloSistema oModuloSistema)
        {
            return datos.Crear_ModuloSistema(oModuloSistema);
        }

        public string Actualizar_ModuloSistema(ModuloSistema oModuloSistema)
        {
            return datos.Actualizar_ModuloSistema(oModuloSistema);
        }

        public DataTable Buscar_ModuloSistema(int Id)
        {
            return datos.Buscar_ModuloSistema(Id);
        }

        public int Eliminar_ModuloSistema(int Id)
        {
            return datos.Eliminar_ModuloSistema(Id);
        }

    }
}
