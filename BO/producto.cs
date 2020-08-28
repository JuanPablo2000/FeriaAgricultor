using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class producto
    {
        public decimal ID_PRODUCTO { get; set; }
        public string NOMBRE_PRODUCTO { get; set; }
        public decimal PRECIO_KILO { get; set; }
        public decimal PRECIO_UNIDAD { get; set; }
        public decimal ID_VENDEDOR { get; set; }

        public virtual vendedor VENDEDOR { get; set; }
    }
}
