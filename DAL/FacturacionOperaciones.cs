using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FacturacionOperaciones
    {
        public static transportista Buscatrasporte(int cedula)
        {
            var transportistas = new transportista();
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    var otransporte = ctx.TRANSPORTISTA.Find (cedula);
                    transportistas = new transportista
                    {
                        NOMBRE = otransporte.NOMBRE,
                        APELLIDO1 = otransporte.APELLIDO1,
                        APELLIDO2 = otransporte.APELLIDO2,
                        TELEFONO = otransporte.TELEFONO,
                        CEDULA = otransporte.CEDULA

                    };
                }
            }
            catch (Exception)
            {
            }

            return transportistas;
        }
        public static cliente BuscarCliente(int cedula)
        {
            var clientes = new cliente();
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    var ocliente = ctx.CLIENTE.Find(cedula);
                    clientes = new cliente
                    {
                        NOMBRE = ocliente.NOMBRE,
                        APELLIDO1 = ocliente.APELLIDO1,
                        APELLIDO2 = ocliente.APELLIDO2,
                        CORREO = ocliente.CORREO,
                        TELEFONO = ocliente.TELEFONO,
                        CEDULA = ocliente.CEDULA

                    };
                }
            }
            catch (Exception)
            {
            }

            return clientes;
        }

        public static vendedor Buscarvendedor(int cedula)
        {
            var vendedores = new vendedor();
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    var ovendedor = ctx.VENDEDOR.Find(cedula);
                    vendedores = new vendedor
                    {
                        NOMBRE = ovendedor.NOMBRE,
                        APELLIDO1 = ovendedor.APELLIDO1,
                        APELLIDO2 = ovendedor.APELLIDO2,
                        TELEFONO = ovendedor.TELEFONO,
                        CEDULA = ovendedor.CEDULA

                    };
                }
            }
            catch (Exception)
            {
            }

            return vendedores;
        }

        public static bool crearFactura(List<factura> facturas) 
        {
            bool mensaje = false;
            var ofactura = new List<FACTURACION>();
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    foreach (var item in facturas) 
                    {
                        ofactura.Add( new FACTURACION
                        {
                            CLIENTE = ctx.CLIENTE.Find(item.ID_CLIENTE),
                            DETALLE_ENTREGA =item.DETALLE_ENTREGA,
                            FECHA = item.FECHA,
                            PRODUCTO = ctx.PRODUCTO.Find(item.ID_PRODUCTO),
                            DIRECCION_ENTREGA = item.DIRECCION_ENTREGA,
                            TOTAL = item.TOTAL,
                            TRANSPORTISTA = ctx.TRANSPORTISTA.Find(item.ID_TRANSPORTISTA),
                            TIPO_PAGO = ctx.TIPO_PAGO.Find(item.COD_PAGO),
                            VENDEDOR = ctx.VENDEDOR.Find(item.ID_VENDEDOR)

                        });
                    }

                    ofactura.ForEach(ofacturas => ctx.FACTURACION.Add(ofacturas));
                    ctx.SaveChanges();
                    mensaje = true;
                }
            }
            catch (Exception)
            {
                mensaje = false;
            }
            return mensaje;
        }

        public static List<transportista> ListarTransportista()
        {
            List<transportista> otransportistas = new List<transportista>();
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    var lisTransportista = ctx.TRANSPORTISTA.ToList();

                    foreach (var item in lisTransportista)
                    {

                        var vehiculos = ctx.VEHICULO.Find(item.ID_VEHICULO);
                        var tipo = ctx.TIPO_VEHICULO.Find(vehiculos.ID_TIPO);
                        var tipoVehiculo = new tipo_vehiculo
                        {
                            ID_TIPO = tipo.ID_TIPO,
                            NOMBRE = tipo.NOMBRE
                        };
                        var ovehiculo = new vehiculo
                        {
                            TIPO_VEHICULO= tipoVehiculo
                        };
                        otransportistas.Add(
                            new transportista
                            {
                                NOMBRE = item.NOMBRE,
                                APELLIDO1 = item.APELLIDO1,
                                APELLIDO2 = item.APELLIDO2,
                                TELEFONO = item.TELEFONO,
                                CORREO = item.CORREO,
                                CEDULA = item.CEDULA,
                                VEHICULO = ovehiculo
                            });
                    }
                }
            }
            catch (Exception)
            {
            }
            return otransportistas;
        }
        public static List<factura> ListarFactura(int cedula)
        {
            List<factura> oFactura = new List<factura>();
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    var listFactura = ctx.FACTURACION.ToList();

                    foreach (var item in listFactura)
                    {
                        if (item.ID_CLIENTE == cedula) {
                            oFactura.Add(
                            new factura
                            {
                                ID_CLIENTE = item.ID_CLIENTE,
                                ID_FACTURACION = item.ID_FACTURACION,
                                ID_TRANSPORTISTA = item.ID_TRANSPORTISTA,
                                DETALLE_ENTREGA = item.DETALLE_ENTREGA,
                                DIRECCION_ENTREGA = item.DIRECCION_ENTREGA,
                                FECHA = item.FECHA,
                                ID_VENDEDOR = item.ID_VENDEDOR,
                                ID_PRODUCTO = item.ID_PRODUCTO,
                                TOTAL = item.TOTAL
                            });
                        }
                        
                    }
                }
            }
            catch (Exception)
            {
            }
            return oFactura;
        }
       

    }
}
