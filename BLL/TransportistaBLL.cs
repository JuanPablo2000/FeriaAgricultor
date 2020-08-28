using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TransportistaBLL
    {
        public static bool CrearTransportista(transportista otransportista, int odistrito, vehiculo vehiculo) 
        {
            return RegistroOperaciones.CrearTransportista(otransportista, odistrito,vehiculo); 
        }
        public static bool Eliminar(int cedula)
        {
            return TransportistaOperaciones.Eliminar(cedula);
        }
        public static bool Editar(transportista otransportista, vehiculo ovehiculo) 
        {
            return TransportistaOperaciones.Editar(otransportista, ovehiculo);
        }
        public static transportista Busca(int cedula)
        {
            return TransportistaOperaciones.Busca(cedula);
        }
    }
}
