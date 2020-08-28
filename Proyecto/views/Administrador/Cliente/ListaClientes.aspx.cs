using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.views.Administrador.Cliente
{
    public partial class ListaClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                CargarCliente();
            }
        }

        protected void btnCrearCliente_Click(object sender, EventArgs e)
        {
            Response.Redirect("Create.aspx");
        }

        protected void gvClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName != "Eliminar") return;

            int id = Convert.ToInt32(e.CommandArgument);
            if (AdministradorBLL.EliminarCliente(id)) 
            {
                CargarCliente();
            }
            else
            {
                List<clsmensaje> oMensajes = new List<clsmensaje>();
                clsmensaje mensaje = new clsmensaje()
                {
                    Id = 1,
                    Descripcion = "Error al eliminar el cliente"
                };
                oMensajes.Add(mensaje);
                blMensajes.DataValueField = "Id";
                blMensajes.DataTextField = "Descripcion";
                blMensajes.DataSource = oMensajes;
                blMensajes.DataBind();
                pnlMensaje.Visible = true;
            }
        }

        public void CargarCliente() 
        {
            Exception raise = null;
            try
            {
                gvClientes.DataSource = AdministradorBLL.ListarCliente();
                gvClientes.DataBind();
            }
            catch (Exception ex)
            {
                raise = ex;
            }
            finally
            {
                if (raise != null)
                {
                    List<clsmensaje> oMensajes = new List<clsmensaje>();
                    clsmensaje mensaje = new clsmensaje()
                    {
                        Id = 1,
                        Descripcion = raise.Message
                    };
                    oMensajes.Add(mensaje);
                    blMensajes.DataValueField = "Id";
                    blMensajes.DataTextField = "Descripcion";
                    blMensajes.DataSource = oMensajes;
                    blMensajes.DataBind();
                    pnlMensaje.Visible = true;
                }
            }
        }
    }
}