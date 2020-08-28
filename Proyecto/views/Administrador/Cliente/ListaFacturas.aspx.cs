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
    public partial class ListaFacturas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                cargarFacturas();
            }
        }

        protected void gvFacturas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName != "Eliminar") return;

            int id = Convert.ToInt32(e.CommandArgument);
            if (AdministradorBLL.EliminarFactura(id))
            {
                cargarFacturas();
            }
            else
            {
                List<clsmensaje> oMensajes = new List<clsmensaje>();
                clsmensaje mensaje = new clsmensaje()
                {
                    Id = 1,
                    Descripcion = "Error al eliminar la factura seleccionada"
                };
                oMensajes.Add(mensaje);
                blMensajes.DataValueField = "Id";
                blMensajes.DataTextField = "Descripcion";
                blMensajes.DataSource = oMensajes;
                blMensajes.DataBind();
                pnlMensaje.Visible = true;
            }
        }
        public void cargarFacturas() 
        {
            Exception raise = null;
            try
            {
                gvFacturas.DataSource = AdministradorBLL.ListarTodasFactura();
                gvFacturas.DataBind();
                var cantidadFacturas = AdministradorBLL.ListarTodasFactura().Count;
                if (cantidadFacturas == 0)
                {
                    List<clsmensaje> oMensajes = new List<clsmensaje>();
                    clsmensaje mensaje = new clsmensaje()
                    {
                        Id = 1,
                        Descripcion = "No tienes facturas para mostrar."
                    };
                    oMensajes.Add(mensaje);
                    blMensajes.DataValueField = "Id";
                    blMensajes.DataTextField = "Descripcion";
                    blMensajes.DataSource = oMensajes;
                    blMensajes.DataBind();
                    pnlMensaje.Visible = true;
                }
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
                        Descripcion = "No tienes facturas para mostrar."
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