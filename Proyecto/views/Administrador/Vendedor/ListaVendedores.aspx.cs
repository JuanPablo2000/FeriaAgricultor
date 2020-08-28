using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.views.Administrador.Vendedor
{
    public partial class ListaVendedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                cargarVendedor();
            }
            pnlMensaje.Visible = false;
        }

        protected void btnCrearVendedor_Click(object sender, EventArgs e)
        {
            Response.Redirect("Create.aspx");
        }
        public void cargarVendedor() 
        {
            Exception raise = null;
            try
            {
                gvVendedor.DataSource = AdministradorBLL.ListarVendedor();
                gvVendedor.DataBind();
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

        protected void gvVendedor_RowCommand(object sender, GridViewCommandEventArgs e)
        {
           
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Eliminar") 
            {
                if (AdministradorBLL.EliminarVendedor(id))
                {
                    cargarVendedor();
                }
                else
                {
                    List<clsmensaje> oMensajes = new List<clsmensaje>();
                    clsmensaje mensaje = new clsmensaje()
                    {
                        Id = 1,
                        Descripcion = "Error al eliminar el usuario, ya que contiene una factura a su nombre"
                    };
                    oMensajes.Add(mensaje);
                    blMensajes.DataValueField = "Id";
                    blMensajes.DataTextField = "Descripcion";
                    blMensajes.DataSource = oMensajes;
                    blMensajes.DataBind();
                    pnlMensaje.Visible = true;
                }
            }
            
            if (e.CommandName == "Habilitar")
            {
                int cedula = Convert.ToInt32(e.CommandArgument);
                if (AdministradorBLL.habilitar("vendedor", cedula))
                {
                    cargarVendedor();
                }
            }
            if (e.CommandName == "Desabilitatr")
            {
                int cedula = Convert.ToInt32(e.CommandArgument);
                if (AdministradorBLL.desabilitar("vendedor", cedula))
                {
                    cargarVendedor();
                }
            }
        }
    }
}