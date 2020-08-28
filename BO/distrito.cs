using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class distrito
    {
        public decimal ID_DISTRITO { get; set; }
        public string NOMBRE_DISTRITO { get; set; }
        public decimal ID_PROVINCIA { get; set; }
        public decimal ID_CANTON { get; set; }

        public virtual canton CANTON { get; set; }

        public virtual provincia PROVINCIA { get; set; }
    }
}
