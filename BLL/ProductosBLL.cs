using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductosBLL
    {
        public static bool CrearProductos(int id, producto produc)
        {

            return ProductoOperaciones.CrearProductos(id, produc);

        }

        public static producto DatosProducto(int idproducto)
        {
            return ProductoOperaciones.Datosproducto(idproducto);
        }

        public static bool EditarProducto(producto produc)
        {

            return ProductoOperaciones.editarproducto(produc);

        }
        public static bool DeleteProduct(producto produc)
        {

            return ProductoOperaciones.Eliminar(produc);

        }
    }
}
