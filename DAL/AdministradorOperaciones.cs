using BO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdministradorOperaciones
    {
        public static List<vendedor> ListarVendedor()
        {
            List<vendedor> vendedores = new List<vendedor>();
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    var ovendedor = ctx.VENDEDOR.ToList();

                    foreach (var item in ovendedor)
                    {
                        var oPago = ctx.TIPO_PAGO.Find(item.COD_PAGO);
                        var oDistrito = ctx.DISTRITO.Find(item.ID_DISTRITO);
                        var oTipoPagos = new tipo_pago
                        {
                            COD_PAGO = oPago.COD_PAGO,
                            TIPO = oPago.TIPO
                        };
                        var distritos = new distrito
                        {
                            NOMBRE_DISTRITO = oDistrito.NOMBRE_DISTRITO,
                            ID_DISTRITO = oDistrito.ID_DISTRITO
                        };
                        vendedores.Add(
                            new vendedor
                            {
                                NOMBRE = item.NOMBRE,
                                APELLIDO1 = item.APELLIDO1,
                                APELLIDO2 = item.APELLIDO2,
                                TELEFONO = item.TELEFONO,
                                CORREO = item.CORREO,
                                COD_PAGO = oTipoPagos.COD_PAGO,
                                CEDULA = item.CEDULA,
                                nombre_pago = oTipoPagos.TIPO,
                                DISTRITO = distritos, 
                                CONTRASENA = item.CONTRASENA,
                                USUARIO = item.USUARIO,
                                HABILITADO= item.HABILITADO
                            });
                    }
                }
            }
            catch (Exception)
            {
            }
            return vendedores;
        }
        public static List<cliente> ListarCliente()
        {
            List<cliente> clientes = new List<cliente>();
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    var ocliente = ctx.CLIENTE.ToList();
                    foreach (var item in ocliente)
                    {
                        var oDistrito = ctx.DISTRITO.Find(item.ID_DISTRITO);
                        var distritos = new distrito
                        {
                            NOMBRE_DISTRITO = oDistrito.NOMBRE_DISTRITO,
                            ID_DISTRITO = oDistrito.ID_DISTRITO
                        };
                        clientes.Add(
                            new cliente
                            {
                                NOMBRE = item.NOMBRE,
                                APELLIDO1 = item.APELLIDO1,
                                APELLIDO2 = item.APELLIDO2,
                                TELEFONO = item.TELEFONO,
                                CORREO = item.CORREO,
                                CEDULA = item.CEDULA,
                                USUARIO = item.USUARIO,
                                DISTRITO = distritos,
                                CONTRASENA = item.CONTRASENA
                            });
                    }
                }
            }
            catch (Exception)
            {
            }
            return clientes;
        }

        public static List<transportista> ListarTransportista()
        {
            List<transportista> transportistas = new List<transportista>();
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    var otransportistas = ctx.TRANSPORTISTA.ToList();

                    foreach (var item in otransportistas)
                    {
                        var oDistrito = ctx.DISTRITO.Find(item.ID_DISTRITO);
                        var vehiculos = ctx.VEHICULO.Find(item.ID_VEHICULO);
                        var tipo = ctx.TIPO_VEHICULO.Find(vehiculos.ID_TIPO);
                        
                        var distritos = new distrito
                        {
                            NOMBRE_DISTRITO = oDistrito.NOMBRE_DISTRITO,
                            ID_DISTRITO = oDistrito.ID_DISTRITO
                        };
                        var otipoVehiculo = new tipo_vehiculo
                        {
                            ID_TIPO = tipo.ID_TIPO,
                            NOMBRE = tipo.NOMBRE
                        };
                        var ovehiculo = new vehiculo 
                        {
                            TIPO_VEHICULO = otipoVehiculo,
                            COLOR = vehiculos.COLOR,
                            MARCA = vehiculos.MARCA,
                            MODELO = vehiculos.MODELO,
                            PLACA = vehiculos.PLACA,
                            ID_VEHICULO = vehiculos.ID_VEHICULO
                        };
                        transportistas.Add(
                            new transportista
                            {
                                NOMBRE = item.NOMBRE,
                                APELLIDO1 = item.APELLIDO1,
                                APELLIDO2 = item.APELLIDO2,
                                TELEFONO = item.TELEFONO,
                                CORREO = item.CORREO,
                                CEDULA = item.CEDULA,
                                DISTRITO = distritos,
                                TIPO_LICENCIA = item.TIPO_LICENCIA,
                                USUARIO = item.USUARIO,
                                CONTRASENA = item.CONTRASENA,
                                VEHICULO = ovehiculo,
                                HABILITADO = item.HABILITADO
                            });
                    }
                }
            }
            catch (Exception)
            {
            }
            return transportistas;
        }
        public static List<factura> ListarTodasFactura()
        {
            List<factura> oFactura = new List<factura>();
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    var listFactura = ctx.FACTURACION.ToList();

                    foreach (var item in listFactura)
                    {
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
            catch (Exception)
            {
            }
            return oFactura;
        }
        public static bool EliminarTransportista(int Cedula)
        {
            bool resultado = false;
            bool validar = false;
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    var listFactura = ctx.FACTURACION.ToList();

                    foreach (var item in listFactura)
                    {
                        if (item.ID_TRANSPORTISTA == Cedula)
                        {
                            validar = true;
                        }

                    }
                    if (!validar) 
                    {
                        TRANSPORTISTA transportista = ctx.TRANSPORTISTA.Find(Cedula);
                        ctx.TRANSPORTISTA.Remove(transportista);
                        ctx.SaveChanges();
                        resultado = true;
                    }
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
            }

            return resultado;
        }
        public static bool EliminarCliente(int Cedula)
        {
            bool resultado = false;
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    CLIENTE ocliente = ctx.CLIENTE.Find(Cedula);
                    ctx.CLIENTE.Remove(ocliente);
                    ctx.SaveChanges();
                    resultado = true;
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
            }

            return resultado;
        }
        public static bool EliminarFactura(int idFactura)
        {
            bool resultado = false;
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    FACTURACION ofactura = ctx.FACTURACION.Find(idFactura);
                    ctx.FACTURACION.Remove(ofactura);
                    ctx.SaveChanges();
                    resultado = true;
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
            }

            return resultado;
        }
        public static bool EliminarVendedor(int Cedula)
        {
            bool resultado = false;
            bool validar = false;
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    var listFactura = ctx.FACTURACION.ToList();

                    foreach (var item in listFactura)
                    {
                        if (item.ID_VENDEDOR == Cedula)
                        {
                            validar = true;
                        }

                    }
                    if (!validar) 
                    {
                        VENDEDOR ovendedor = ctx.VENDEDOR.Find(Cedula);
                        ctx.VENDEDOR.Remove(ovendedor);
                        ctx.SaveChanges();
                        resultado = true;
                    }
                    
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
            }

            return resultado;
        }
        public static bool habilitar(string tipoUsuario, int cedula) 
        {
            bool mensaje = false;
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    if (tipoUsuario == "transportista") 
                    {
                        var transportista = ctx.TRANSPORTISTA.Find(cedula);
                        transportista.HABILITADO = true;
                        ctx.TRANSPORTISTA.Add(transportista);
                        ctx.Entry(transportista).State = EntityState.Modified;
                        ctx.SaveChanges();
                        mensaje = true;
                    }
                    if (tipoUsuario == "vendedor") 
                    {
                        var vendedor = ctx.VENDEDOR.Find(cedula);
                        vendedor.HABILITADO = true;
                        ctx.VENDEDOR.Add(vendedor);
                        ctx.Entry(vendedor).State = EntityState.Modified;
                        ctx.SaveChanges();
                        mensaje = true;
                    }
                    
                }
            }
            catch (Exception)
            {
                mensaje = false;
            }
            return mensaje;
        }
        public static bool desabilitar(string tipoUsuario, int cedula) 
        {
            bool mensaje = false;
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    if (tipoUsuario == "transportista")
                    {
                        var transportista = ctx.TRANSPORTISTA.Find(cedula);
                        transportista.HABILITADO = false;
                        ctx.TRANSPORTISTA.Add(transportista);
                        ctx.Entry(transportista).State = EntityState.Modified;
                        ctx.SaveChanges();
                        mensaje = true;
                    }
                    if (tipoUsuario == "vendedor")
                    {
                        var vendedor = ctx.VENDEDOR.Find(cedula);
                        vendedor.HABILITADO = false;
                        ctx.VENDEDOR.Add(vendedor);
                        ctx.Entry(vendedor).State = EntityState.Modified;
                        ctx.SaveChanges();
                        mensaje = true;
                    }

                }
            }
            catch (Exception)
            {
                mensaje = false;
            }
            return mensaje;
        }
        public static bool editarVendedor(vendedor ovendedor, int odistrito)
        {
            bool resultado = false;
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    var vendedores = ctx.VENDEDOR.Find(ovendedor.CEDULA);
                    vendedores.APELLIDO1 = ovendedor.APELLIDO1;
                    vendedores.APELLIDO2 = ovendedor.APELLIDO2;
                    vendedores.CORREO = ovendedor.CORREO;
                    vendedores.NOMBRE = ovendedor.NOMBRE;
                    vendedores.DISTRITO = ctx.DISTRITO.Find(odistrito);
                    vendedores.TELEFONO = ovendedor.TELEFONO;
                    vendedores.CONTRASENA = ovendedor.CONTRASENA;
                    vendedores.USUARIO = ovendedor.USUARIO;

                    ctx.VENDEDOR.Add(vendedores);
                    ctx.Entry(vendedores).State = EntityState.Modified;
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
