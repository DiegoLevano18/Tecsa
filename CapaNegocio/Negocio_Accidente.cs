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
    public class Negocio_Accidente
    {

        Datos_Accidente datos = new Datos_Accidente();

        public DataTable Vista_Accidente()
        {
            return datos.Vista_Accidente();
        }

        public string Crear_Accidente(Accidente oAccidente)
        {
            return datos.Crear_Accidente(oAccidente);
        }

        public string Actualizar_Accidente(Accidente oAccidente)
        {
            return datos.Actualizar_Accidente(oAccidente);
        }

        public DataTable Buscar_Accidente(int Id)
        {
            return datos.Buscar_Accidente(Id);
        }

        public int Eliminar_Accidente(int Id)
        {
            return datos.Eliminar_Accidente(Id);
        }

    }
}
