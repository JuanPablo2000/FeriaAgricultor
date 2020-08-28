using BO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductoOperaciones
    {
        public static bool editarproducto(producto oproducto)
        {
            bool resultado = false;
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    var productoedit = ctx.PRODUCTO.Find(oproducto.ID_PRODUCTO);
                    productoedit.NOMBRE_PRODUCTO = oproducto.NOMBRE_PRODUCTO;
                    productoedit.PRECIO_KILO = oproducto.PRECIO_KILO;
                    productoedit.PRECIO_UNIDAD = oproducto.PRECIO_UNIDAD;
                    productoedit.ID_VENDEDOR = productoedit.ID_VENDEDOR;
                    ctx.PRODUCTO.Add(productoedit);
                    ctx.Entry(productoedit).State = EntityState.Modified;
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
        public static bool Eliminar(producto product)
        {
            bool resultado = false;
            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    var producDelete = ctx.PRODUCTO.Find(product.ID_PRODUCTO);
                    producDelete.NOMBRE_PRODUCTO = product.NOMBRE_PRODUCTO;
                    producDelete.PRECIO_KILO = product.PRECIO_KILO;
                    producDelete.PRECIO_UNIDAD = product.PRECIO_UNIDAD;
                    producDelete.ID_VENDEDOR = product.ID_VENDEDOR;
                    ctx.PRODUCTO.Remove(producDelete);
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
        public static List<producto> ListarProdctos()
        {
            List<producto> product = new List<producto>();
            using (var ctx = new FeriaDBcontext())
            {
                var articulo = ctx.PRODUCTO.ToList();
                foreach (var item in articulo)
                {
                    product.Add(
                        new producto
                        {
                            ID_PRODUCTO = item.ID_PRODUCTO,
                            NOMBRE_PRODUCTO = item.NOMBRE_PRODUCTO,
                            ID_VENDEDOR = item.ID_VENDEDOR,
                            PRECIO_KILO = item.PRECIO_KILO,
                            PRECIO_UNIDAD = item.PRECIO_UNIDAD,


                        }
                        );
                }
            }
            return product;
        }
        public static bool CrearProductos(int id, producto oproduc)
        {
            bool resultado = false;
            try
            {
                using (var ctx = new FeriaDBcontext())
                {

                    var oProducto = new PRODUCTO()
                    {
                        ID_PRODUCTO = oproduc.ID_PRODUCTO,
                        NOMBRE_PRODUCTO = oproduc.NOMBRE_PRODUCTO,
                        PRECIO_KILO = oproduc.PRECIO_KILO,
                        PRECIO_UNIDAD = oproduc.PRECIO_UNIDAD,
                        ID_VENDEDOR = id

                    };

                    ctx.PRODUCTO.Add(oProducto);
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
        public static producto Datosproducto(int idproducto)
        {
            var oproduc = new producto();

            try
            {
                using (var ctx = new FeriaDBcontext())
                {
                    PRODUCTO produc = ctx.PRODUCTO.Find(idproducto);
                    oproduc = new producto
                    {
                        ID_PRODUCTO = idproducto,
                        NOMBRE_PRODUCTO = produc.NOMBRE_PRODUCTO,
                        ID_VENDEDOR = produc.ID_VENDEDOR,
                        PRECIO_KILO = produc.PRECIO_KILO,
                        PRECIO_UNIDAD = produc.PRECIO_UNIDAD
                    };
                }
            }
            catch (Exception)
            {
            }

            return oproduc;
        }
    }
}
