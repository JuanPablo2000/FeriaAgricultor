using BO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TransportistaOperaciones
    {
        public static bool Eliminar(int Cedula)
        {
            bool resultado = false;
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    TRANSPORTISTA otransportista = ctx.TRANSPORTISTA.Find(Cedula);
                    ctx.TRANSPORTISTA.Remove(otransportista);
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
        public static transportista Busca(int cedula)
        {
            transportista oTransportistas = new transportista();
            try
            {
                using (var ctx = new FeriaDBcontext())
                {

                    TRANSPORTISTA transportista = ctx.TRANSPORTISTA.Find(cedula);
                    var vehiculos = ctx.VEHICULO.Find(transportista.ID_VEHICULO);
                    var tipo = ctx.TIPO_VEHICULO.Find(vehiculos.ID_TIPO);
                    var tipoVehiculo = new tipo_vehiculo
                    {
                        ID_TIPO = tipo.ID_TIPO,
                        NOMBRE = tipo.NOMBRE
                    };
                    var ovehiculo = new vehiculo
                    {
                        TIPO_VEHICULO = tipoVehiculo,
                        PLACA = vehiculos.PLACA,
                        MODELO = vehiculos.MODELO,
                        MARCA = vehiculos.MARCA,
                        COLOR = vehiculos.COLOR
                    };
                    oTransportistas.CEDULA = transportista.CEDULA;
                    oTransportistas.NOMBRE = transportista.NOMBRE;
                    oTransportistas.APELLIDO1 = transportista.APELLIDO1;
                    oTransportistas.APELLIDO2 = transportista.APELLIDO2;
                    oTransportistas.CORREO = transportista.CORREO;
                    oTransportistas.TELEFONO = transportista.TELEFONO;
                    oTransportistas.USUARIO = transportista.USUARIO;
                    oTransportistas.CONTRASENA = transportista.CONTRASENA;
                    oTransportistas.ID_DISTRITO = transportista.ID_DISTRITO;
                    oTransportistas.TIPO_LICENCIA = transportista.TIPO_LICENCIA;
                    oTransportistas.VEHICULO = ovehiculo;
                }
            }
            catch (Exception)
            {
            }

            return oTransportistas;
        }

        public static bool Editar(transportista otransportista, vehiculo ovehiculo)
        {
            bool resultado = false;
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    var transportista = ctx.TRANSPORTISTA.Find(otransportista.CEDULA);
                    var vehiculos = new VEHICULO
                    {
                        ID_VEHICULO = transportista.ID_VEHICULO,
                        COLOR = ovehiculo.COLOR,
                        MARCA = ovehiculo.MARCA,
                        ID_TIPO = ovehiculo.ID_TIPO,
                        MODELO = ovehiculo.MODELO,
                        PLACA = ovehiculo.PLACA,
                    };

                    transportista.NOMBRE = otransportista.NOMBRE;
                    transportista.APELLIDO1 = otransportista.APELLIDO1;
                    transportista.APELLIDO2 = otransportista.APELLIDO2;
                    transportista.CORREO = otransportista.CORREO;
                    transportista.TELEFONO = otransportista.TELEFONO;
                    transportista.DISTRITO = ctx.DISTRITO.Find(otransportista.ID_DISTRITO);
                    transportista.TIPO_LICENCIA = otransportista.TIPO_LICENCIA;
                    transportista.VEHICULO = vehiculos;

                    ctx.TRANSPORTISTA.Add(transportista);
                    ctx.Entry(transportista).State = EntityState.Modified;
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
