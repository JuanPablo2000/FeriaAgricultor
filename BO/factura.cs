using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class factura
    {
        public decimal ID_FACTURACION { get; set; }
        public System.DateTime FECHA { get; set; }
        public decimal ID_VENDEDOR { get; set; }
        public decimal ID_CLIENTE { get; set; }
        public string DIRECCION_ENTREGA { get; set; }
        public decimal ID_TRANSPORTISTA { get; set; }
        public string DETALLE_ENTREGA { get; set; }
        public decimal ID_PRODUCTO { get; set; }
        public decimal COD_PAGO { get; set; }
        public decimal TOTAL { get; set; }

        public virtual cliente CLIENTE { get; set; }
        public virtual vendedor VENDEDOR { get; set; }
        public virtual transportista TRANSPORTISTA { get; set; }
        public virtual producto PRODUCTO { get; set; }
        public virtual tipo_pago TIPO_PAGO { get; set; }
    }
}
