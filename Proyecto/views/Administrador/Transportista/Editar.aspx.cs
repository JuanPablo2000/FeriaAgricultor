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
    public partial class Editar : System.Web.UI.Page
    {
        public decimal oprovincia;
        public decimal ocanton;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Request.QueryString["CEDULA"] == null)
                    Response.Redirect("ListaTransportista.aspx");
                int id = 0;
                id = int.TryParse(Request.QueryString["CEDULA"].ToString(), out id) ? id : 0;
                cargarDatos(id);
                cargarDropDownlist(id);
            }
            pnlMensaje.Visible = false;

        }
        public void cargarDatos(int cedula)
        {
            transportista otransportista = TransportistaBLL.Busca(cedula);
            txtNombre.Text = otransportista.NOMBRE;
            txtIdentificacion.Text = otransportista.CEDULA.ToString();
            txtApellido1.Text = otransportista.APELLIDO1;
            txtApellido2.Text = otransportista.APELLIDO2;
            txtEmail.Text = otransportista.CORREO;
            txtTelefono.Text = otransportista.TELEFONO.ToString();
            txtLicencia.Text = otransportista.TIPO_LICENCIA;
            txtColor.Text = otransportista.VEHICULO.COLOR;
            txtMarca.Text = otransportista.VEHICULO.MARCA;
            txtModelo.Text = otransportista.VEHICULO.MODELO;
            txtPlaca.Text = otransportista.VEHICULO.PLACA.ToString();

        }
        public void cargarDropDownlist(int cedula)
        {
            transportista otransportista = TransportistaBLL.Busca(cedula);
            var oid_distrito = decimal.ToInt32(otransportista.ID_DISTRITO);

            var tipoVehiculo = otransportista.VEHICULO.TIPO_VEHICULO.ID_TIPO;
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
            List<tipo_vehiculo> vehiculos = UtilidadesBLL.ListarVehiculo();
            foreach (var item in vehiculos)
            {
                ListItem oVehiculo = new ListItem(item.NOMBRE, item.ID_TIPO.ToString());
                dllTipoVehiculo.Items.Add(oVehiculo);
                if (tipoVehiculo == item.ID_TIPO)
                {
                    dllTipoVehiculo.SelectedItem.Text = item.NOMBRE;
                    dllTipoVehiculo.SelectedValue = item.ID_TIPO.ToString();
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

        protected void btnCrear(object sender, EventArgs e)
        {
            var odistrito = int.Parse(dllDistrito.SelectedValue.ToString());
            var oVehiculo = int.Parse(dllTipoVehiculo.SelectedValue.ToString());
            Exception raise = null;
            try
            {
                var ovehiculo = new vehiculo
                {
                    ID_TIPO = oVehiculo,
                    COLOR = txtColor.Text,
                    MARCA = txtMarca.Text,
                    MODELO = txtModelo.Text,
                    PLACA = decimal.Parse(txtPlaca.Text)
                };
                var otransportista = new transportista
                {
                    CEDULA = decimal.Parse(txtIdentificacion.Text),
                    NOMBRE = txtNombre.Text,
                    APELLIDO1 = txtApellido1.Text,
                    APELLIDO2 = txtApellido2.Text,
                    CORREO = txtEmail.Text,
                    TELEFONO = decimal.Parse(txtTelefono.Text),
                    TIPO_LICENCIA = txtLicencia.Text,
                    ID_DISTRITO = odistrito,
                    CONTRASENA = txtContraseña.Text,
                    USUARIO= txtUsuario.Text
                    

                };
                if (TransportistaBLL.Editar(otransportista, ovehiculo))
                {
                    Response.Redirect("ListaTransportista.aspx"); // poner un mensaje de que se actualizo correctamente
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
            catch (Exception ex)
            {
                raise = ex;
            }
        }
    }
} 