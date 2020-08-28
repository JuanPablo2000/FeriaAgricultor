using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.views.Facturacion
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            if (!IsPostBack)
            {
                txtFecha.Text = DateTime.Now.ToString();
                var cliente = (int)Session["cliente"];
                var vendedor = (int)Session["vendedor"];
                CargarCliente(cliente);
                CargarVendedor(vendedor);
                cargarDropdowList();
                cargarProductos();
            }


        }

        public void cargarProductos()
        {
            List<producto> oProductos = (List<producto>)Session["productos"];
            gvProductos.DataSource = oProductos.ToList();
            txtTOTAL.Text = Session["total"].ToString();
            gvProductos.DataBind();
        }
        public void CargarCliente(int cedula)
        {


            cliente ocliente = ClienteBLL.DatosCliente(cedula);
            txtNombreliente.Text = ocliente.APELLIDO1;
            txtApellido1.Text = ocliente.APELLIDO1;
            txtApellido2.Text = ocliente.APELLIDO2;
            txtCorreo.Text = ocliente.CORREO;
            txtCedulaCliente.Text = ocliente.CEDULA.ToString();
            TXTTelefono.Text = ocliente.TELEFONO.ToString();

        }


        public void cargarDropdowList()
        {
            // carga provincia

            List<transportista> transportistas = FacturacionBLL.ListarTransportista();
            foreach (var item in transportistas)
            {
                string datosTransportista = item.NOMBRE + " " + item.APELLIDO1 + " | vehiculo " + item.VEHICULO.TIPO_VEHICULO.NOMBRE;
                ListItem otransportista = new ListItem(datosTransportista, item.CEDULA.ToString());
                dllTransportista.Items.Add(otransportista);
            }

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
                dllPago.Items.Add(oPagos);
            }


        }
        public void CargarVendedor(int vendedor)
        {
            vendedor ovendedor = FacturacionBLL.Buscarvendedor(vendedor);
            TxtNombreVendedor.Text = ovendedor.NOMBRE;
            TxtApellido1Vendedor.Text = ovendedor.APELLIDO1;
            TxtApellido2Vendedor.Text = ovendedor.APELLIDO2;
            TxtCedulaVendedor.Text = ovendedor.CEDULA.ToString();
            TxtTelefonoVendedor.Text = ovendedor.TELEFONO.ToString();

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

        protected void btnFactura_Click(object sender, EventArgs e)
        {
            var ofactura = new List<factura>();
            var id = dllDistrito.SelectedItem.ToString();
            var pago = int.Parse(dllPago.SelectedValue.ToString());
            decimal total = (decimal)Session["total"];
            foreach (GridViewRow row in gvProductos.Rows)
            {
                ofactura.Add(
                       new factura
                       {
                           ID_CLIENTE = int.Parse(txtCedulaCliente.Text),
                           FECHA = DateTime.Now,
                           DETALLE_ENTREGA = txtDetalleEntrega.Text,
                           DIRECCION_ENTREGA = id.ToString(),
                           ID_PRODUCTO = int.Parse(row.Cells[0].Text),
                           ID_TRANSPORTISTA = int.Parse(txtTrasportista.Text),
                           ID_VENDEDOR = int.Parse(TxtCedulaVendedor.Text),
                           COD_PAGO = pago,
                           TOTAL = total,


                       });
            }
            if (FacturacionBLL.crearFactura(ofactura))
            {
                List<clsmensaje> oMensajes = new List<clsmensaje>();
                clsmensaje mensaje = new clsmensaje()
                {
                    Id = 1,
                    Descripcion = "Compra Realizada"
                };
                oMensajes.Add(mensaje);
                blMensajesInfo.DataValueField = "Id";
                blMensajesInfo.DataTextField = "Descripcion";
                blMensajesInfo.DataSource = oMensajes;
                blMensajesInfo.DataBind();
                pnlInfo.Visible = true;
            }
            else 
            {
                List<clsmensaje> oMensajes = new List<clsmensaje>();
                clsmensaje mensaje = new clsmensaje()
                {
                    Id = 1,
                    Descripcion = "No se puede realizar la compra, verifique sus datos"
                };
                oMensajes.Add(mensaje);
                blMensajes.DataValueField = "Id";
                blMensajes.DataTextField = "Descripcion";
                blMensajes.DataSource = oMensajes;
                blMensajes.DataBind();
                pnlMensaje.Visible = true;
            }
        }

        protected void dllTransportista_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cedula = int.Parse(dllTransportista.SelectedValue);
            transportista ocliente = FacturacionBLL.Buscatrasporte(cedula);
            txtNombreTrasportista.Text = ocliente.NOMBRE;
            txtApellido1Trasportista.Text = ocliente.APELLIDO1;
            txtApellido2Trasportista.Text = ocliente.APELLIDO2;
            txtTrasportista.Text = ocliente.CEDULA.ToString();
            txtTelefonoTras.Text = ocliente.TELEFONO.ToString();
        }
    }
}