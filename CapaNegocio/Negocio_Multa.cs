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
    public class Negocio_Multa
    {

        Datos_Multa datos = new Datos_Multa();

        public DataTable Vista_Multa()
        {
            return datos.Vista_Multa();
        }

        public string Crear_Multa(Multa oMulta)
        {
            return datos.Crear_Multa(oMulta);
        }

        public string Actualizar_Multa(Multa oMulta)
        {
            return datos.Actualizar_Multa(oMulta);
        }

        public DataTable Buscar_Multa(int Id)
        {
            return datos.Buscar_Multa(Id);
        }

        public int Eliminar_Multa(int Id)
        {
            return datos.Eliminar_Multa(Id);
        }

    }
}
