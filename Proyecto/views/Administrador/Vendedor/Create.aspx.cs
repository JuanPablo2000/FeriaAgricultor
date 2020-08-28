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
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarDropdowList();

            }
            pnlMensaje.Visible = false;
        }
        public void cargarDropdowList()
        {
            // carga provincia
            List<provincia> provincia = UtilidadesBLL.ListarProvincia();
            foreach (var item in provincia)
            {
                ListItem oProvincia = new ListItem(item.NOMBRE_PROVINCIA, item.ID_PROVINCIA.ToString());
                dllProvincia.Items.Add(oProvincia);
            }

            //carga canton
            List<canton> canton = UtilidadesBLL.ListarCanton();
            foreach (var item in canton)
            {
                ListItem oCanton = new ListItem(item.NOMBRE_CANTON, item.ID_CANTON.ToString());
                dllCanton.Items.Add(oCanton);
            }

            //carga distrito
            List<distrito> distritos = UtilidadesBLL.ListarDistrito();
            foreach (var item in distritos)
            {
                ListItem oDistrito = new ListItem(item.NOMBRE_DISTRITO, item.ID_DISTRITO.ToString());
                dllDistrito.Items.Add(oDistrito);
            }


            //carga tipo_pago
            List<tipo_pago> pagos = UtilidadesBLL.ListarPago();
            foreach (var item in pagos)
            {
                ListItem oPagos = new ListItem(item.TIPO, item.COD_PAGO.ToString());
                dllTipoPago.Items.Add(oPagos);
            }


        }

        protected void dllProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id_provincia = dllProvincia.SelectedValue.ToString();
            dllCanton.Items.Clear();
            List<canton> canton = UtilidadesBLL.ListarCanton();
            foreach (var item in canton)
            {
                if (item.ID_PROVINCIA == int.Parse(id_provincia))
                {
                    ListItem oCanton = new ListItem(item.NOMBRE_CANTON, item.ID_CANTON.ToString());
                    dllCanton.Items.Add(oCanton);
                }
            }

        }

        protected void dllCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id_canton = dllCanton.SelectedValue.ToString();
            dllDistrito.Items.Clear();
            List<distrito> odistrito = UtilidadesBLL.ListarDistrito();
            foreach (var item in odistrito)
            {
                if (item.ID_CANTON == int.Parse(id_canton))
                {
                    ListItem distritos = new ListItem(item.NOMBRE_DISTRITO, item.ID_DISTRITO.ToString());
                    dllDistrito.Items.Add(distritos);
                }

            }
        }

        protected void btnCrear(object sender, EventArgs e)
        {
            Exception raise = null;
            try
            {
                var id = int.Parse(dllDistrito.SelectedValue.ToString());
                var pago = int.Parse(dllTipoPago.SelectedValue.ToString());
                var oVendedor = new vendedor
                {
                    NOMBRE = txtNombre.Text,
                    APELLIDO1 = txtApellido1.Text,
                    APELLIDO2 = txtApellido2.Text,
                    CEDULA = Convert.ToInt32(txtIdentificacion.Text),
                    CONTRASENA = txtContraseña.Text,
                    CORREO = txtEmail.Text,
                    ROL = "vendedor",
                    TELEFONO = Convert.ToInt32(txtTelefono.Text),
                    USUARIO = txtUsuario.Text,

                };

                if (VendedorBLL.CrearVendedor(oVendedor, id, pago))
                    Response.Redirect("~/views/Administrador/Vendedor/ListaVendedores.aspx");
                else
                {
                    List<clsmensaje> oMensajes = new List<clsmensaje>();
                    clsmensaje mensaje = new clsmensaje()
                    {
                        Id = 1,
                        Descripcion = "Datos incorrectos, verificar su información."
                    };
                    oMensajes.Add(mensaje);
                    blMensajes.DataValueField = "Id";
                    blMensajes.DataTextField = "Descripcion";
                    blMensajes.DataSource = oMensajes;
                    blMensajes.DataBind();
                    pnlMensaje.Visible = true;
                }

            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        raise = new InvalidOperationException(message, raise);
                    }
                }
            }
            catch (Exception ex)
            {
                raise = ex;
            }
        }
    }


}