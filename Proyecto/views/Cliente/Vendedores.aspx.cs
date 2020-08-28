using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.views.Cliente
{
    public partial class Vendedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                cargarVendedores();
            }
        }

        public void cargarVendedores() 
        {
            Exception raise = null;
            try
            {
                gvVendedores.DataSource = ClienteBLL.ListarVendedor();
                gvVendedores.DataBind();
            }
            catch (Exception ex)
            {
                raise = ex;
            }
            finally
            {
                //if (raise != null)
                //{
                //    List<clsMensaje> oMensajes = new List<clsMensaje>();
                //    clsMensaje mensaje = new clsMensaje()
                //    {
                //        Id = 1,
                //        Descripcion = raise.Message
                //    };
                //    oMensajes.Add(mensaje);
                //    blMensajes.DataValueField = "Id";
                //    blMensajes.DataTextField = "Descripcion";
                //    blMensajes.DataSource = oMensajes;
                //    blMensajes.DataBind();
                //    pnlMensaje.Visible = true;
            }
        }
    }
}
