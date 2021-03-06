﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class transportista
    {
        public decimal CEDULA { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO1 { get; set; }
        public string APELLIDO2 { get; set; }
        public string CORREO { get; set; }
        public decimal TELEFONO { get; set; }
        public string USUARIO { get; set; }
        public string CONTRASENA { get; set; }
        public decimal ID_DISTRITO { get; set; }
        public bool HABILITADO { get; set; }
        public string TIPO_LICENCIA { get; set; }
        public decimal ID_VEHICULO { get; set; }
        public string ROL { get; set; }

        public virtual distrito DISTRITO { get; set; }
        public virtual vehiculo VEHICULO { get; set; }
    }
}
