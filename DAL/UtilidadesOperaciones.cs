using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UtilidadesOperaciones
    {
        public static List<distrito> ListarDistrito()
        {
            List<distrito> odistrito = new List<distrito>();
            using (var ctx = new FeriaDBcontext())
            {
                var dis = ctx.DISTRITO.ToList();
                foreach (var item in dis)
                {
                    odistrito.Add(
                    new distrito
                    {
                        ID_DISTRITO = item.ID_DISTRITO,
                        NOMBRE_DISTRITO = item.NOMBRE_DISTRITO,
                        ID_CANTON = item.ID_CANTON
                    }
                    );


                }
            }
            return odistrito;
        }
        public static List<canton> ListarCanton()
        {
            List<canton> oCanton = new List<canton>();
            using (var ctx = new FeriaDBcontext())
            {
                var cant = ctx.CANTON.ToList();
                foreach (var item in cant)
                {
                    oCanton.Add(
                    new canton
                    {
                        ID_CANTON = item.ID_CANTON,
                        NOMBRE_CANTON = item.NOMBRE_CANTON,
                        ID_PROVINCIA = item.ID_PROVINCIA

                    }
                    );

                }
            }
            return oCanton;
        }

        public static List<provincia> ListarProvincia()
        {
            List<provincia> oprovincia = new List<provincia>();
            using (var ctx = new FeriaDBcontext())
            {
                var prov = ctx.PROVINCIA.ToList();
                foreach (var item in prov)
                {
                    oprovincia.Add(
                        new provincia
                        {
                            ID_PROVINCIA = item.ID_PROVINCIA,
                            NOMBRE_PROVINCIA = item.NOMBRE_PROVINCIA
                        }
                        );
                }
            }
            return oprovincia;
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
                        var oPago = ctx.TIPO_PAGO.Find(item.COD_PAGO);
                        var oTipoPagos = new tipo_pago
                        {
                            COD_PAGO = oPago.COD_PAGO,
                            TIPO = oPago.TIPO
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
                                nombre_pago = oTipoPagos.TIPO
                            });
                    }
                }
            }
            catch (Exception)
            {
            }
            return vendedores;
        }
        public static List<tipo_vehiculo> ListarVehiculo()
        {
            List<tipo_vehiculo> vehiculo = new List<tipo_vehiculo>();
            using (var ctx = new FeriaDBcontext())
            {
                var automovil = ctx.TIPO_VEHICULO.ToList();
                foreach (var item in automovil)
                {
                    vehiculo.Add(
                        new tipo_vehiculo
                        {
                            ID_TIPO = item.ID_TIPO,
                            NOMBRE = item.NOMBRE
                        }
                        );
                }
            }
            return vehiculo;
        }

        public static List<tipo_pago> ListarPago()
        {
            List<tipo_pago> pago = new List<tipo_pago>();
            using (var ctx = new FeriaDBcontext())
            {
                var tipo_pago = ctx.TIPO_PAGO.ToList();
                foreach (var item in tipo_pago)
                {
                    pago.Add(
                        new tipo_pago
                        {
                            COD_PAGO = item.COD_PAGO,
                            TIPO = item.TIPO
                        }
                        );
                }
            }
            return pago;
        }

    }
}
