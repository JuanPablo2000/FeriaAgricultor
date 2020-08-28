using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class canton
    {
        public decimal ID_CANTON { get; set; }
        public string NOMBRE_CANTON { get; set; }
        public decimal ID_PROVINCIA { get; set; }

        public virtual provincia PROVINCIA { get; set; }
    }
}
