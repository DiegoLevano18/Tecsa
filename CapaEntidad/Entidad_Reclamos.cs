﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Reclamos
    {
        public int IdReclamo { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Correo { get; set; }
        public string MotivoReclamo { get; set; }
        public string Fecha { get; set; }
    }
}
