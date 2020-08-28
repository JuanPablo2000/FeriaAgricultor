using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.views.Login
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                pnlMensaje.Visible = false;
                
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login/registro.aspx");
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string validar = LoginBLL.validarRol(int.Parse(txtUsuario.Text),txtContraseña.Text);
            if (validar == "cliente")
            {
                Session["cliente"] = int.Parse(txtUsuario.Text);
                Response.Redirect("../Cliente/PerfilCliente.aspx");

            }
            else if (validar == "vendedor")
            {
                Session["vendedor"] = int.Parse(txtUsuario.Text);
                Response.Redirect("../Vendedor/VendedorDashboard.aspx?cedula=" + txtUsuario.Text);
            }
            else if (validar == "administrador")
            {
                Session["administrador"] = int.Parse(txtUsuario.Text);
                Response.Redirect("../Administrador/Cliente/ListaCLientes.aspx");
            } else if (validar == "transportista") 
            {
                Session["transportista"] = int.Parse(txtUsuario.Text);
                Response.Redirect("../Transportista/Editar.aspx");
            }
            else if (validar == "")
            {
                List<clsmensaje> oMensajes = new List<clsmensaje>();
                clsmensaje mensaje = new clsmensaje()
                {
                    Id = 1,
                    Descripcion = "Datos incorrectos, verificar sus datos. Si no se encuenta registrado dar click en el botón registrar"
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