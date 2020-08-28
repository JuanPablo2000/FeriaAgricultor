using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.views.Productos
{
    public partial class DeleteProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var cedula = (int)Session["vendedor"];
                CargarVendedor(cedula);
                CargarProduct();

            }
        }
        public void CargarVendedor(int cedula)
        {
            vendedor ovendedor = VendedorBLL.DatosVendedor(cedula);
            Label1.Text = ovendedor.NOMBRE;;

        }
        public void CargarProduct()
        {


            int id = int.Parse(Request.Params["productid"]);
            producto oproduc = ProductosBLL.DatosProducto(id);
            txtNombreProducto.Text = oproduc.NOMBRE_PRODUCTO;
            PrecioKilo.Text = oproduc.PRECIO_KILO.ToString();
            PrecioUnidad.Text = oproduc.PRECIO_UNIDAD.ToString();
            id_vendedor.Text = oproduc.ID_VENDEDOR.ToString();
            txtNombreProducto.Enabled = false;
            PrecioKilo.Enabled = false;
            PrecioUnidad.Enabled = false;
        }
        protected void btndeleteproduct_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.Params["productid"]);
            var oproducto = new producto
            {
                ID_PRODUCTO = id,
                NOMBRE_PRODUCTO = txtNombreProducto.Text,
                PRECIO_KILO = (decimal)double.Parse(PrecioKilo.Text),
                PRECIO_UNIDAD = (decimal)double.Parse(PrecioUnidad.Text),
                ID_VENDEDOR = (decimal)double.Parse(id_vendedor.Text)
            };

            if (ProductosBLL.DeleteProduct(oproducto))
            {

                Response.Redirect("../Vendedor/VendedorDashboard.aspx?cedula=" + oproducto.ID_VENDEDOR.ToString());
            }

        }
    }
}