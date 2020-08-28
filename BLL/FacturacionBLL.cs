using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FacturacionBLL
    {
        public static transportista Buscatrasporte(int cedula)
        {
            return FacturacionOperaciones.Buscatrasporte(cedula);
        }
        public static vendedor Buscarvendedor(int cedula)
        {
            return FacturacionOperaciones.Buscarvendedor(cedula);
        }
        public static cliente BuscarCliente(int cedula)
        {
            return FacturacionOperaciones.BuscarCliente(cedula);
        }
        public static bool crearFactura(List<factura> facturas) 
        {
            return FacturacionOperaciones.crearFactura(facturas);
        }
        public static List<transportista> ListarTransportista() 
        {
            return FacturacionOperaciones.ListarTransportista();
        }
        public static List<factura> ListarFactura( int cedula) {
            return FacturacionOperaciones.ListarFactura(cedula);
        }
    }
}
