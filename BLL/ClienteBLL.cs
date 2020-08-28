using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteBLL
    {
        public static bool CrearCliente(cliente oUsuario, int distrito) {
            return RegistroOperaciones.CrearCliente(oUsuario, distrito);
        }
        public static cliente DatosCliente(int cedula)
        {
            return ClienteOperaciones.DatosCliente(cedula);
        }
        public static bool editar(cliente ocliente, int odistrito) 
        {
            return ClienteOperaciones.editar(ocliente, odistrito);
        }
        public static List<producto> ListarProducto(int cedulaVendedor) 
        {
            return ClienteOperaciones.ListarProducto(cedulaVendedor);
        }
        public static List<vendedor> ListarVendedor() 
        {
            return ClienteOperaciones.ListarVendedor();
        }
    }
}
