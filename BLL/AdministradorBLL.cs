using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AdministradorBLL
    {
        public static List<cliente> ListarCliente() 
        {
            return AdministradorOperaciones.ListarCliente();
        }
        public static List<vendedor> ListarVendedor() 
        {
            return AdministradorOperaciones.ListarVendedor();
        }
        public static List<transportista> ListarTransportista() 
        {
            return AdministradorOperaciones.ListarTransportista();
        }
        public static bool EliminarTransportista(int Cedula) 
        {
            return AdministradorOperaciones.EliminarTransportista(Cedula);
        }
        public static bool EliminarCliente(int Cedula) 
        {
            return AdministradorOperaciones.EliminarCliente(Cedula);
        }
        public static bool EliminarVendedor(int Cedula) 
        {
            return AdministradorOperaciones.EliminarVendedor(Cedula);
        }
        public static bool habilitar(string tipoUsuario, int cedula) 
        {
            return AdministradorOperaciones.habilitar(tipoUsuario, cedula);
        }
        public static bool desabilitar(string tipoUsuario, int cedula) 
        {
            return AdministradorOperaciones.desabilitar(tipoUsuario,cedula);
        }
        public static bool editarVendedor(vendedor ovendedor, int odistrito)
        {
            return AdministradorOperaciones.editarVendedor(ovendedor,odistrito);
        }
        public static bool EliminarFactura(int idFactura) 
        {
            return AdministradorOperaciones.EliminarFactura(idFactura);
        }
        public static List<factura> ListarTodasFactura() 
        {
            return AdministradorOperaciones.ListarTodasFactura();
        }

    }
}
