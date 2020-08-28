using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.views.Vendedor
{
    public partial class EditVendedor : System.Web.UI.Page
    {
        public decimal oprovincia;
        public decimal ocanton;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var cedula = (int)Session["vendedor"];
                CargarVendedor(cedula);
                cargarDropDownlist();
            }

        }
        public void CargarVendedor(int cedula)
        {
            vendedor ovendedor = VendedorBLL.DatosVendedor(cedula);
            Label1.Text = ovendedor.NOMBRE;
            txtApellido1.Text = ovendedor.APELLIDO1;
            txtApellido2.Text = ovendedor.APELLIDO2;
            txtNombre.Text = ovendedor.NOMBRE;
            txtEmail.Text = ovendedor.CORREO;
            txtTelefono.Text = ovendedor.TELEFONO.ToString();

        }
        public void cargarDropDownlist()
        {
            var cedula = (int)Session["vendedor"];
            vendedor ovendedor = VendedorBLL.DatosVendedor(cedula);
            var oid_distrito = decimal.ToInt32(ovendedor.ID_DISTRITO);

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

        protected void btnEditar(object sender, EventArgs e)
        {
            var cedula = (int)Session["vendedor"];
            var odistrito = int.Parse(dllDistrito.SelectedValue.ToString());
            var oVendedor = new vendedor
            {
                CEDULA = cedula,
                NOMBRE = txtNombre.Text,
                APELLIDO1 = txtApellido1.Text,
                APELLIDO2 = txtApellido2.Text,

                CORREO = txtEmail.Text,
                TELEFONO = int.Parse(txtTelefono.Text),

            };

            if (VendedorBLL.EditVendedor(oVendedor, odistrito))
            {

                Response.Redirect("VendedorDashboard.aspx?cedula=" + cedula.ToString());

            }


        }

        protected void dllCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id_canton = dllCanton.SelectedValue.ToString();
            var id_provincia = dllProvincia.SelectedValue.ToString();
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
    }
}