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
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            if (IsPostBack)
            {
                validarVendedor();
            }

            CargarVendedor();
        }
        public void CargarVendedor()
        {
            var cedula = int.Parse(Request.Params["cedula"]);
            vendedor ovendedor = VendedorBLL.DatosVendedor(cedula);
            Label1.Text = ovendedor.NOMBRE;
        }
        public void validarVendedor()
        {
            if (Request.QueryString["CEDULA"] == null)
                Response.Redirect("../Vendedor/VendedorDashboard.aspx");
            id_vendedor.Value = Request.QueryString["CEDULA"].ToString();

        }
        protected void btnSubmitP(object sender, EventArgs e)
        {
            var cedula = int.Parse(Request.Params["cedula"]);
            producto producs = new producto();
            producs.NOMBRE_PRODUCTO = NombreProduct.Text;
            producs.PRECIO_KILO = (decimal)double.Parse(PrecioKilo.Text);
            producs.PRECIO_UNIDAD = (decimal)double.Parse(PrecioUnidad.Text);
            if (ProductosBLL.CrearProductos(cedula, producs))
            {
                Response.Redirect("../Vendedor/VendedorDashboard.aspx?cedula=" + id_vendedor.Value.ToString());
            }

        }
    }
}