using BO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VendedorOperaciones
    {
        public static vendedor DatosVendedor(int cedula)
        {
            var ovendedor = new vendedor();

            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    VENDEDOR vendedores = ctx.VENDEDOR.Find(cedula);
                    ovendedor = new vendedor
                    {
                        NOMBRE = vendedores.NOMBRE,
                        APELLIDO1 = vendedores.APELLIDO1,
                        APELLIDO2 = vendedores.APELLIDO2,
                        CEDULA = vendedores.CEDULA,
                        CONTRASENA = vendedores.CONTRASENA,
                        CORREO = vendedores.CORREO,
                        ID_DISTRITO = vendedores.ID_DISTRITO,
                        TELEFONO = vendedores.TELEFONO,
                        USUARIO = vendedores.USUARIO
                    };
                }
            }
            catch (Exception)
            {
            }

            return ovendedor;
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
