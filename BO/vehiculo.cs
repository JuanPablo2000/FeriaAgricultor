using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class vehiculo
    {
        public decimal ID_VEHICULO { get; set; }
        public decimal PLACA { get; set; }
        public string MARCA { get; set; }
        public string MODELO { get; set; }
        public string COLOR { get; set; }
        public decimal ID_TIPO { get; set; }

        public virtual tipo_vehiculo TIPO_VEHICULO { get; set; }
    }
}
