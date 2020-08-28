using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.views.Cliente
{
    public partial class CompraProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                validarVendedor();
                cargarProductos();

            }

            pnlMensaje.Visible = false;
        }
        public void cargarProductos() 
        {
            Exception raise = null;
            try
            {
                gvProducto.DataSource = ClienteBLL.ListarProducto(int.Parse( id_vendedor.Value));
                gvProducto.DataBind();
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
                        Descripcion = "Seleccionar un producto"
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

        public void validarVendedor() 
        {
            if (Request.QueryString["CEDULA"] == null)
                Response.Redirect("../cliente/Vendedores.aspx");
            id_vendedor.Value = Request.QueryString["CEDULA"].ToString();

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal montodeKilo = 0;
            decimal montodeUnidad = 0;
            decimal montoTotal = 0;
            bool validar = false;
            foreach (GridViewRow row in gvProducto.Rows) 
            {
                CheckBox check = row.FindControl("CheckSeleccionado") as CheckBox;
                TextBox txtcantidadKilo = row.FindControl("kilo") as TextBox;
                TextBox txtcantidadUnidad = row.FindControl("unidad") as TextBox;

                if (check.Checked)
                {
                    decimal precioKilo = decimal.Parse(row.Cells[3].Text);
                    decimal precioUnidad = decimal.Parse(row.Cells[4].Text);
                    validar = true;

                    if (txtcantidadKilo.Text !="" && txtcantidadUnidad.Text !="")
                    {
                        montodeKilo = precioKilo * decimal.Parse(txtcantidadKilo.Text);
                        montodeUnidad = precioUnidad * decimal.Parse(txtcantidadUnidad.Text);
                        montoTotal += montodeUnidad + montodeKilo;

                    }else if (txtcantidadKilo.Text != "")
                    {
                        montodeKilo = precioKilo * decimal.Parse(txtcantidadKilo.Text);
                        montoTotal += montodeKilo;
                    }
                    else if (txtcantidadUnidad.Text != "")
                    {

                        montodeUnidad = precioUnidad * decimal.Parse(txtcantidadUnidad.Text);
                        montoTotal += montodeUnidad;
                    }
                    else {
                        List<clsmensaje> oMensajes = new List<clsmensaje>();
                        clsmensaje mensaje = new clsmensaje()
                        {
                            Id = 1,
                            Descripcion = "Colocar un mónto en los campos de texto-"
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
            if (!validar) 
            {
                List<clsmensaje> oMensajes = new List<clsmensaje>();
                clsmensaje mensaje = new clsmensaje()
                {
                    Id = 1,
                    Descripcion = "Seleccionar un producto"
                };
                oMensajes.Add(mensaje);
                blMensajes.DataValueField = "Id";
                blMensajes.DataTextField = "Descripcion";
                blMensajes.DataSource = oMensajes;
                blMensajes.DataBind();
                pnlMensaje.Visible = true;
            }
            txtTotal.Text = montoTotal.ToString();

            Session["total"] = decimal.Parse(txtTotal.Text);
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            var oProductos = new List<producto>();
            bool validar = false;
            foreach (GridViewRow row in gvProducto.Rows)
            {
                CheckBox check = row.FindControl("CheckSeleccionado") as CheckBox;
                if (check.Checked)
                {
                    validar = true;
                    oProductos.Add (
                        new producto
                    {
                        ID_PRODUCTO = decimal.Parse(row.Cells[1].Text),
                        NOMBRE_PRODUCTO = row.Cells[2].Text
                    });

                }
            }
            if (validar) 
            {
                Session["productos"] = oProductos;
                Session["vendedor"] = int.Parse(id_vendedor.Value);
                Response.Redirect("../Facturacion/index.aspx");

            }
            else
            {

                List<clsmensaje> oMensajes = new List<clsmensaje>();
                clsmensaje mensaje = new clsmensaje()
                {
                    Id = 1,
                    Descripcion = "Seleccionar un producto"
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