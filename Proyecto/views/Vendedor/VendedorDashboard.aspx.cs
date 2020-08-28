using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.views.Vendedor
{
    public partial class VendedorDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            validarVendedor();
            CargarVendedor();
            cargarProductos();
        }
        public void CargarVendedor()
        {
            var cedula = (int)Session["vendedor"];

            vendedor ovendedor = VendedorBLL.DatosVendedor(cedula);
            Label1.Text = ovendedor.NOMBRE;
        }
        public void validarVendedor()
        {
            var cedula = (int)Session["vendedor"];
            if ((int)Session["vendedor"] == 0)
                Response.Redirect("../Vendedor/VendedorDashboard.aspx?cedula");
            id_vendedor.Value = cedula.ToString();

        }

        public void cargarProductos()
        {
            Exception raise = null;
            try
            {
                gvProductos.DataSource = ClienteBLL.ListarProducto(int.Parse(id_vendedor.Value));
                gvProductos.DataBind();
            }
            catch (Exception ex)
            {
                raise = ex;
            }
            finally
            {
            }
        }
        protected void btnCrea_Click(object sender, EventArgs e)
        {
            var cedula = (int)Session["vendedor"];
            vendedor ovendedor = VendedorBLL.DatosVendedor(cedula);
            Response.Redirect("../Productos/Create.aspx?cedula=" + ovendedor.CEDULA);

        }
        protected void btnredirect(object sender, EventArgs e)
        {
            var cedula = int.Parse(Request.Params["cedula"]);
            vendedor ovendedor = VendedorBLL.DatosVendedor(cedula);
            Response.Redirect("../Vendedor/VendedorDashboard.aspx?cedula=" + +ovendedor.CEDULA);
        }
    }
}