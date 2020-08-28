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
    public partial class registro : System.Web.UI.Page
    {
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                cargarDropdowList();
                
            }
            pnlMensaje.Visible = false;

        }

        
        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            var id = int.Parse(dllDistrito.SelectedValue.ToString());
            if (RolUser.Value == "cliente")
            {
                Exception raise = null;
                try
                {
                    var oCliente = new cliente
                    {
                        NOMBRE = txtNombre.Text,
                        APELLIDO1 = txtApellido1.Text,
                        APELLIDO2 = txtApellido2.Text,
                        CEDULA = Convert.ToInt32(txtIdentificacion.Text),
                        CONTRASENA = txtContraseñaCliente.Text,
                        CORREO = txtEmail.Text,
                        ROL = "cliente",
                        TELEFONO = Convert.ToInt32(txtTelefono.Text),
                        USUARIO = txtUsuarioCliente.Text,
                    };

                    if (ClienteBLL.CrearCliente(oCliente, id))
                        Response.Redirect("~/views/Login/index.aspx");
                    else
                    {

                        throw new Exception("Ocurrió un error al insertar el cliente: " + txtNombre.Text);
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
            else if (RolUser.Value == "vendedor")
            {

                var pago = int.Parse(dllTipoPago.SelectedValue.ToString());
                Exception raise = null;
                try
                {
                    var oVendedor = new vendedor
                    {
                        NOMBRE = txtNombre.Text,
                        APELLIDO1 = txtApellido1.Text,
                        APELLIDO2 = txtApellido2.Text,
                        CEDULA = Convert.ToInt32(txtIdentificacion.Text),
                        CONTRASENA = txtVendedorContraseña.Text,
                        CORREO = txtEmail.Text,
                        ROL = "vendedor",
                        TELEFONO = Convert.ToInt32(txtTelefono.Text),
                        USUARIO = txtVendedorUsuario.Text,
                        
                    };

                    if (VendedorBLL.CrearVendedor(oVendedor,id,pago))
                        Response.Redirect("~/views/Login/index.aspx");
                    else
                    {

                        throw new Exception("Ocurrió un error al insertar el Vendedor: " + txtNombre.Text);
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
            else if (RolUser.Value == "transportista")
            {

                var tipoVehiculo = int.Parse(dllTipoVehiculo.SelectedValue.ToString());
                Exception raise = null;
                try
                {
                    var otransportista = new transportista
                    {
                        NOMBRE = txtNombre.Text,
                        APELLIDO1 = txtApellido1.Text,
                        APELLIDO2 = txtApellido2.Text,
                        CEDULA = Convert.ToInt32(txtIdentificacion.Text),
                        CONTRASENA = txtContraseñaTrasnportista.Text,
                        CORREO = txtEmail.Text,
                        TELEFONO = Convert.ToInt32(txtTelefono.Text),
                        USUARIO = txtUsuarioTransportista.Text,
                        TIPO_LICENCIA = txtLicencia.Text,
                        ROL = "transportista"
                        

                    };

                    var oVehiculo = new vehiculo
                    {
                        COLOR = txtColor.Text,
                        MARCA = txtMarca.Text,
                        ID_TIPO = tipoVehiculo,
                        PLACA = int.Parse(txtPlaca.Text),
                        MODELO = txtModelo.Text

                    };

                    if (TransportistaBLL.CrearTransportista(otransportista, id, oVehiculo)) 
                    {
                        Response.Redirect("~/views/Login/index.aspx");
                    }
                    else
                    {

                        throw new Exception("Ocurrió un error al insertar el Vendedor: " + txtNombre.Text);
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
            else 
            {
                List<clsmensaje> oMensajes = new List<clsmensaje>();
                clsmensaje mensaje = new clsmensaje()
                {
                    Id = 1,
                    Descripcion = "Indicar cual su rol en la sección 2"
                };
                oMensajes.Add(mensaje);
                blMensajes.DataValueField = "Id";
                blMensajes.DataTextField = "Descripcion";
                blMensajes.DataSource = oMensajes;
                blMensajes.DataBind();
                pnlMensaje.Visible = true;
                //throw raise;
            }

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

            // carga tipo_Vehiculo
            List<tipo_vehiculo> vehiculos = UtilidadesBLL.ListarVehiculo();
            foreach (var item in vehiculos)
            {
                ListItem oVehiculo = new ListItem(item.NOMBRE, item.ID_TIPO.ToString());
                dllTipoVehiculo.Items.Add(oVehiculo);
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
                if (item.ID_CANTON== int.Parse(id_canton) )
                {
                    ListItem distritos = new ListItem(item.NOMBRE_DISTRITO, item.ID_DISTRITO.ToString());
                    dllDistrito.Items.Add(distritos);
                }

            }
        }
    }
}