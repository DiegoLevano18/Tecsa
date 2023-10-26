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
    public class Negocio_LicenciaConducir
    {

        Datos_LicenciaConducir datos = new Datos_LicenciaConducir();

        public DataTable Vista_LicenciaConducir()
        {
            return datos.Vista_LicenciaConducir();
        }

        public string Crear_LicenciaConducir(LicenciaConducir oLicenciaConducir)
        {
            return datos.Crear_LicenciaConducir(oLicenciaConducir);
        }

        public string Actualizar_LicenciaConducir(LicenciaConducir oLicenciaConducir)
        {
            return datos.Actualizar_LicenciaConducir(oLicenciaConducir);
        }

        public DataTable Buscar_LicenciaConducir(int Id)
        {
            return datos.Buscar_LicenciaConducir(Id);
        }

        public int Eliminar_LicenciaConducir(int Id)
        {
            return datos.Eliminar_LicenciaConducir(Id);
        }

    }
}
