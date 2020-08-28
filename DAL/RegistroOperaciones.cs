using BO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RegistroOperaciones
    {

        public static bool CrearCliente(cliente oUsuario, int distrito )
        {
            bool resultado = false;
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                   
                    var oCliente = new CLIENTE()
                    {
                        CEDULA = oUsuario.CEDULA,
                        NOMBRE = oUsuario.NOMBRE,
                        APELLIDO1 = oUsuario.APELLIDO1,
                        APELLIDO2 = oUsuario.APELLIDO2,
                        CONTRASENA = oUsuario.CONTRASENA,
                        CORREO = oUsuario.CORREO,
                        DISTRITO = ctx.DISTRITO.Find(distrito),
                        ROL = oUsuario.ROL,
                        TELEFONO = oUsuario.TELEFONO,
                        USUARIO = oUsuario.USUARIO,
                    };

                    ctx.CLIENTE.Add(oCliente);
                    ctx.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception)
            {
                resultado = false;
            }

            return resultado;
        }

        public static bool CrearVendedor(vendedor vendedores, int odistrito, int pago)
        {
            bool resultado = false;
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    
                    var oVendedor = new VENDEDOR()
                    {
                        CEDULA = vendedores.CEDULA,
                        NOMBRE = vendedores.NOMBRE,
                        APELLIDO1 = vendedores.APELLIDO1,
                        APELLIDO2 = vendedores.APELLIDO2,
                        CONTRASENA = vendedores.CONTRASENA,
                        CORREO = vendedores.CORREO,
                        DISTRITO = ctx.DISTRITO.Find(odistrito),
                        ROL = vendedores.ROL,
                        TELEFONO = vendedores.TELEFONO,
                        USUARIO = vendedores.USUARIO,
                        TIPO_PAGO = ctx.TIPO_PAGO.Find(pago)
                    };

                    ctx.VENDEDOR.Add(oVendedor);
                    ctx.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception)
            {
                resultado = false;
            }



            return resultado;
        }

        public static bool CrearTransportista( transportista otransportista, int odistrito, vehiculo vehiculo)
        {
            bool resultado = false;
            try
            {
                using (var ctx = new FeriaDBcontext())
                {

                    var automovil = new VEHICULO()
                    {
                        COLOR = vehiculo.COLOR,
                        TIPO_VEHICULO = ctx.TIPO_VEHICULO.Find(vehiculo.ID_TIPO),
                        MARCA= vehiculo.MARCA,
                         MODELO= vehiculo.MODELO,
                         PLACA= vehiculo.PLACA,

                    };
                    var oTransportista = new TRANSPORTISTA()
                    {
                        CEDULA = otransportista.CEDULA,
                        NOMBRE = otransportista.NOMBRE,
                        APELLIDO1 = otransportista.APELLIDO1,
                        APELLIDO2 = otransportista.APELLIDO2,
                        CONTRASENA = otransportista.CONTRASENA,
                        CORREO = otransportista.CORREO,
                        DISTRITO = ctx.DISTRITO.Find(odistrito),
                        TELEFONO = otransportista.TELEFONO,
                        USUARIO = otransportista.USUARIO,
                        TIPO_LICENCIA = otransportista.TIPO_LICENCIA,
                        VEHICULO =automovil,
                        ROL = otransportista.ROL
                        

                    };

                    ctx.TRANSPORTISTA.Add(oTransportista);
                    ctx.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception)
            {
                resultado = false;
            }



            return resultado;
        }
    
    }
}
