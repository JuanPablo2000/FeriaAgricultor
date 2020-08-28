using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VendedorBLL
    {
        public static bool CrearVendedor(vendedor vendedores, int odistrito, int pago) 
        {
            return RegistroOperaciones.CrearVendedor(vendedores,odistrito,pago);
        }
        public static vendedor DatosVendedor(int cedula)
        {
            return VendedorOperaciones.DatosVendedor(cedula);
        }
        public static bool EditVendedor(vendedor ovendedor, int odistrito)
        {

            return VendedorOperaciones.editarVendedor(ovendedor, odistrito);

        }
    }
}
