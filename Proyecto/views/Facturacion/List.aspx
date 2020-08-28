<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Proyecto.views.Facturacion.List" %>

<!DOCTYPE html>

<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>
    Feria
  </title>
   <link href="../../../css/estilos.css" rel="stylesheet" />
    <link href="../../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../../Scripts/jquery-3.0.0.min.js"></script>
    <script src="../../../Scripts/bootstrap.bundle.min.js"></script>
    <script src="../../../Scripts/popper.min.js"></script>
  <!--     Fonts and icons     -->
  <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons" />
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css">
  <!-- CSS Files -->
 <link href="../../../css/material-dashboard.css" rel="stylesheet" />

</head>
<body class="dark-edition">
    <div class="wrapper ">
    <div class="sidebar" data-color="purple" data-background-color="white" data-image="../../images/form-wizard-bg.jpg">
      <div class="logo"><a href="#" class="simple-text logo-normal"><img src="../../images/step-1.png"  /><br />
          Feria
        </a></div>
      <div class="sidebar-wrapper">
        <ul class="nav">
          <li class="nav-item ">
            <a class="nav-link" href="../../views/Cliente/PerfilCliente.aspx">
              <i class="material-icons">create</i>
              <p style="color: white">Perfil</p>
            </a>
          </li>

          <li class="nav-item ">
            <a class="nav-link" href="../../views/Cliente/Vendedores.aspx">
              <i class="material-icons">fact_check</i>
              <p style="color: white">Compra de Productos</p>
            </a>
          </li>
          <li class="nav-item ">
            <a class="nav-link" href="../../views/Facturacion/List.aspx">
              <i class="material-icons">content_paste</i>
              <p style="color: white">Facturacion</p>
            </a>
          </li>
         
        </ul>
      </div>
    </div>
    <div class="main-panel">
      <!-- Navbar -->
      <nav class="navbar navbar-expand-lg navbar-transparent navbar-absolute fixed-top " id="navigation-example">
        <div class="container-fluid">
          <div class="navbar-wrapper">
            <a class="navbar-brand" href="#">Feria del Agricultor</a>
          </div>
          <div class="collapse navbar-collapse justify-content-between">
            <ul class="navbar-nav">>
              <li class="nav-item">
                <a class="nav-link" href="../../views/Login/index.aspx">
                  <asp:Image ID="Image2" runat="server" ImageUrl="~/images/salida.png" />
                  <p class="d-lg-none d-md-block">
                    Exit
                  </p>
                </a>
              </li>
            </ul>
          </div>
        </div>
      </nav>
      <!-- End Navbar -->
      <div class="content">
        <div class="container-fluid">
          <div class="row">
            <div class="col-md-12">
              <div class="card">
                <div class="card-header card-header-primary">
                  <h4 class="card-title">FACTURAS</h4>
                  <p class="card-category">Completar los siguientes campos</p>
                </div>
                <div class="card-body">
                    <form runat="server">
                        <div class="row">
                        <div class="col-md-12">
                            <asp:Panel ID="pnlMensaje" runat="server" Visible="false">
                                <div class="alert alert-danger" role="alert">
                                    <strong>Atención!</strong> Se ha presentado el siguiente problema.
                                    <br />
                                    <br />
                                    <asp:BulletedList ID="blMensajes" runat="server"></asp:BulletedList>
                                </div>
                            </asp:Panel>
                           <asp:GridView ID="gvFacturas" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="789px">
                                <Columns>
                                    <asp:BoundField DataField="ID_FACTURACION" HeaderText="Código Factura" SortExpression="ID_FACTURACION" />
                                    <asp:BoundField DataField="FECHA" HeaderText="Fecha" SortExpression="Fecha" />
                                    <asp:BoundField DataField="ID_VENDEDOR" HeaderText="Vendedor Identificación" SortExpression="Vendedor" />
                                    <asp:BoundField DataField="DIRECCION_ENTREGA" HeaderText="Dirección entrega" SortExpression="Direccion entrega" />
                                    <asp:BoundField DataField="ID_TRANSPORTISTA" HeaderText="Transportista identificación" SortExpression="Transportista identificacion" />
                                    <asp:BoundField DataField="DETALLE_ENTREGA" HeaderText="Detalle Entrega" SortExpression="Detalle entrega" />
                                    <asp:BoundField DataField="ID_PRODUCTO" HeaderText="Codigo Producto" SortExpression="Codigo producto" />
                                    <asp:BoundField DataField="TOTAL" HeaderText="Monto total" SortExpression="monto total" />
                                </Columns>

                                <FooterStyle BackColor="White" ForeColor="#333333" />
                                <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="White" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                                <SortedAscendingHeaderStyle BackColor="#487575" />
                                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                                <SortedDescendingHeaderStyle BackColor="#275353" />
                            </asp:GridView>
              </div>
              </div>
                  </form>
                </div>
              </div>
              </div>
            </div>
          </div>
        </div>
      </div>
        <!----End content-->
      <footer class="footer">
        <div class="container-fluid">
          
          <div class="copyright float-right" id="date">
             <i class="material-icons">favorite</i>
            by 2020,Proyecto Programacion Avanzada
          </div>
        </div>
      </footer>
    </div>

  <!--   Core JS Files   -->
  <script src="../assets/js/core/jquery.min.js"></script>
  <script src="../assets/js/core/popper.min.js"></script>
  <script src="../assets/js/core/bootstrap-material-design.min.js"></script>
  <script src="https://unpkg.com/default-passive-events"></script>
  <script src="../assets/js/plugins/perfect-scrollbar.jquery.min.js"></script>
  <!-- Place this tag in your head or just before your close body tag. -->
  <script async defer src="https://buttons.github.io/buttons.js"></script>
  <!-- Chartist JS -->
  <script src="../assets/js/plugins/chartist.min.js"></script>
  <!--  Notifications Plugin    -->
  <script src="../assets/js/plugins/bootstrap-notify.js"></script>
  <!-- Control Center for Material Dashboard: parallax effects, scripts for the example pages etc -->
  <script src="../assets/js/material-dashboard.js?v=2.1.0"></script>
 

</body>
</html>
