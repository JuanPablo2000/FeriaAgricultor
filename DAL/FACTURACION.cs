//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class FACTURACION
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
    
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual VENDEDOR VENDEDOR { get; set; }
        public virtual TRANSPORTISTA TRANSPORTISTA { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual TIPO_PAGO TIPO_PAGO { get; set; }
    }
}
