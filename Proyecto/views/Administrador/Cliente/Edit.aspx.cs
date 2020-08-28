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
    public partial class Edit : System.Web.UI.Page
    {
        public decimal oprovincia;
        public decimal ocanton;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Request.QueryString["CEDULA"] == null)
                    Response.Redirect("ListaClientes.html");
                int id = 0;
                id = int.TryParse(Request.QueryString["CEDULA"].ToString(), out id) ? id : 0;
                CargarCliente(id);
                cargarDropDownlist(id);
            }
            pnlMensaje.Visible = false;

        }
        public void CargarCliente(int cedula)
        {

            cliente ocliente = ClienteBLL.DatosCliente(cedula);
            txtApellido1.Text = ocliente.APELLIDO1;
            txtApellido2.Text = ocliente.APELLIDO2;
            txtNombre.Text = ocliente.NOMBRE;
            txtEmail.Text = ocliente.CORREO;
            txtIdentificacion.Text = ocliente.CEDULA.ToString();
            txtTelefono.Text = ocliente.TELEFONO.ToString();
            txtContraseña.Text = ocliente.CONTRASENA;
            txtUsuario.Text = ocliente.USUARIO;

        }
        public void cargarDropDownlist(int cedula)
        {
            cliente ocliente = ClienteBLL.DatosCliente(cedula);
            var oid_distrito = decimal.ToInt32(ocliente.ID_DISTRITO);

            List<distrito> distritos = UtilidadesBLL.ListarDistrito();
            foreach (var item in distritos)
            {
                ListItem oDistrito = new ListItem(item.NOMBRE_DISTRITO, item.ID_DISTRITO.ToString());
                dllDistrito.Items.Add(oDistrito);
                if (oid_distrito == item.ID_DISTRITO)
                {
                    dllDistrito.SelectedItem.Text = item.NOMBRE_DISTRITO;
                    dllDistrito.SelectedItem.Value = item.ID_DISTRITO.ToString();

                    ocanton = item.ID_CANTON;
                }
            }

            List<canton> canton = UtilidadesBLL.ListarCanton();
            foreach (var item in canton)
            {
                ListItem oCanton = new ListItem(item.NOMBRE_CANTON, item.ID_CANTON.ToString());
                dllCanton.Items.Add(oCanton);
                if (ocanton == item.ID_CANTON)
                {
                    dllCanton.SelectedItem.Text = item.NOMBRE_CANTON;
                    oprovincia = item.ID_PROVINCIA;
                }
            }
            List<provincia> provincia = UtilidadesBLL.ListarProvincia();
            foreach (var item in provincia)
            {
                ListItem oProvincia = new ListItem(item.NOMBRE_PROVINCIA, item.ID_PROVINCIA.ToString());
                dllProvincia.Items.Add(oProvincia);
                if (oprovincia == item.ID_PROVINCIA)
                {
                    dllProvincia.SelectedItem.Text = item.NOMBRE_PROVINCIA;
                }
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

        protected void btnEditar(object sender, EventArgs e)
        {
            var odistrito = int.Parse(dllDistrito.SelectedValue.ToString());

            var ocliente = new cliente
            {
                NOMBRE = txtNombre.Text,
                APELLIDO1 = txtApellido1.Text,
                APELLIDO2 = txtApellido2.Text,
                CEDULA = int.Parse(txtIdentificacion.Text),
                CORREO = txtEmail.Text,
                TELEFONO = int.Parse(txtTelefono.Text),
                CONTRASENA = txtContraseña.Text,
                USUARIO = txtUsuario.Text
            };

            if (ClienteBLL.editar(ocliente, odistrito))
            {
                Response.Redirect("~/views/Administrador/Cliente/ListaClientes.aspx");
            }
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
    }
}