using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.views.Administrador.Transportista
{
    public partial class ListaTransportista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                cargarTransportista();
            }
            pnlMensaje.Visible = false;
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            Response.Redirect("create.aspx");
        }

        protected void gvTransportista_RowCommand(object sender, GridViewCommandEventArgs e)
        {
          

            if (e.CommandName == "Eliminar")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                if (AdministradorBLL.EliminarTransportista(id))
                {
                    cargarTransportista();
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
            if(e.CommandName =="Habilitar")
            {
                int cedula = Convert.ToInt32(e.CommandArgument);
                if (AdministradorBLL.habilitar("transportista",cedula)) 
                {
                    cargarTransportista();
                }
            }
            if(e.CommandName == "Desabilitatr")
            {
                int cedula = Convert.ToInt32(e.CommandArgument);
                if (AdministradorBLL.desabilitar("transportista", cedula))
                {
                    cargarTransportista();
                }
            }
        }
        public void cargarTransportista() 
        {
            Exception raise = null;
            try
            {
                gvTransportista.DataSource = AdministradorBLL.ListarTransportista();
                gvTransportista.DataBind();
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