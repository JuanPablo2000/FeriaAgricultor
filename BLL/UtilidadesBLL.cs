using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UtilidadesBLL
    {
        public static List<provincia> ListarProvincia()
        {
            return UtilidadesOperaciones.ListarProvincia();
        }
        public static List<canton> ListarCanton()
        {
            return UtilidadesOperaciones.ListarCanton();
        }
        public static List<distrito> ListarDistrito()
        {
            return UtilidadesOperaciones.ListarDistrito();
        }
        public static List<tipo_vehiculo> ListarVehiculo() 
        {
            return UtilidadesOperaciones.ListarVehiculo();
        }
        public static List<tipo_pago> ListarPago() 
        {
            return UtilidadesOperaciones.ListarPago();
        }
    }
}
