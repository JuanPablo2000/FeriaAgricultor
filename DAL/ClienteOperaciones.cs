using BO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteOperaciones
    {
        public static cliente DatosCliente(int cedula)
        {
            var ocliente = new cliente();

            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    CLIENTE clientes = ctx.CLIENTE.Find(cedula);
                    ocliente = new cliente
                    {
                        NOMBRE = clientes.NOMBRE,
                        APELLIDO1 = clientes.APELLIDO1,
                        APELLIDO2 = clientes.APELLIDO2,
                        CEDULA = clientes.CEDULA,
                        CONTRASENA = clientes.CONTRASENA,
                        CORREO = clientes.CORREO,
                        ID_DISTRITO = clientes.ID_DISTRITO,
                        TELEFONO = clientes.TELEFONO,
                        USUARIO = clientes.USUARIO,
                    };
                }
            }
            catch (Exception)
            {
            }

            return ocliente;
        }

        public static bool editar(cliente ocliente, int odistrito) 
        {
            bool resultado = false;
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    var clientes = ctx.CLIENTE.Find(ocliente.CEDULA);
                    clientes.APELLIDO1 = ocliente.APELLIDO1;
                    clientes.APELLIDO2 = ocliente.APELLIDO2;
                    clientes.CORREO = ocliente.CORREO;
                    clientes.NOMBRE = ocliente.NOMBRE;
                    clientes.DISTRITO = ctx.DISTRITO.Find(odistrito);
                    clientes.TELEFONO = ocliente.TELEFONO;
                    clientes.USUARIO = ocliente.USUARIO;
                    clientes.CONTRASENA = ocliente.CONTRASENA;

                    ctx.CLIENTE.Add(clientes);
                    ctx.Entry(clientes).State = EntityState.Modified;
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
        
        public static List<producto> ListarProducto(int cedulaVendedor)
        {
            List<producto> productos = new List<producto>();
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    var oproducto = ctx.PRODUCTO.ToList();
                    foreach (var item in oproducto)
                    {
                        if (item.ID_VENDEDOR == cedulaVendedor) 
                        {
                            productos.Add(
                           new producto
                           {
                               ID_PRODUCTO = item.ID_PRODUCTO,
                               NOMBRE_PRODUCTO = item.NOMBRE_PRODUCTO,
                               PRECIO_KILO = item.PRECIO_KILO,
                               PRECIO_UNIDAD = item.PRECIO_UNIDAD
                           });
                        }
                       
                    }
                }
            }
            catch (Exception)
            {
            }
            return productos;
        }

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
                        vendedores.Add(
                            new vendedor
                            {
                                NOMBRE = item.NOMBRE,
                                APELLIDO1 = item.APELLIDO1,
                                APELLIDO2 = item.APELLIDO2,
                                TELEFONO = item.TELEFONO,
                                CORREO = item.CORREO,
                                COD_PAGO = item.COD_PAGO,
                                CEDULA = item.CEDULA
                            });
                    }
                }
            }
            catch (Exception)
            {
            }
            return vendedores;
        }

    } 
}

