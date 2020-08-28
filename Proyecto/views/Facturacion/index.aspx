<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Proyecto.views.Facturacion.index" %>

<!DOCTYPE html>

<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>
    Feria
  </title>
   <link href="../../css/estilos.css" rel="stylesheet" />
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.0.0.min.js"></script>
    <script src="../../Scripts/bootstrap.bundle.min.js"></script>
    <script src="../../Scripts/popper.min.js"></script>
  <!--     Fonts and icons     -->
  <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons" />
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css">
  <!-- CSS Files -->
  <link href="../../css/material-dashboard.css" rel="stylesheet" />

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
            <ul class="navbar-nav">
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
             <asp:Panel ID="pnlMensaje" runat="server" Visible="false">
                                <div class="alert alert-danger" role="alert">
                                    <strong>Atención!</strong> Se ha presentado el siguiente problema.
                                    <br />
                                    <br />
                                    <asp:BulletedList ID="blMensajes" runat="server"></asp:BulletedList>
                                </div>
                            </asp:Panel>
            <asp:Panel ID="pnlInfo" runat="server" Visible="false">
                                <div class="alert alert-info" >
                                    <asp:BulletedList ID="blMensajesInfo" runat="server"></asp:BulletedList>
                                </div>
             </asp:Panel>
                <div class="col-md-5">
                    <div class="form-group">
                            <asp:Label ID="lblCedula" runat="server" Text="Fecha:" class="control-label col-md-2" ></asp:Label>
                        <asp:TextBox class="form-control" ID="txtFecha" runat="server" EnableViewState="True"></asp:TextBox>
                    </div>
                </div>

             <div class="row">
                <div class="col-md-6">
                    <div class="form-group">
                            <asp:Label ID="Label10" runat="server" Text="Identificación Cliente:" class="control-label col-md-2"  ></asp:Label>
                        <asp:TextBox  class="form-control" ID="txtCedulaCliente" runat="server" ReadOnly="true" style="color: black" ></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <asp:Label class="bmd-label-floating"  ID="Label3" runat="server" Text="Nombre Cliente"  ReadOnly="true"></asp:Label>
                        <asp:TextBox  class="form-control" ID="txtNombreliente" runat="server"></asp:TextBox>
                    </div>
                      </div>
              </div>
                    <div class="row">
                      <div class="col-md-3">
                          <div class="form-group">
                        <asp:Label class="bmd-label-floating" ID="Label4" runat="server" Text="Apellido 1"  ReadOnly="true"></asp:Label>
                        <asp:TextBox  class="form-control" ID="txtApellido1" runat="server"></asp:TextBox>
                          </div>
                           </div>
                         <div class="col-md-3">
                          <div class="form-group">
                        <asp:Label class="bmd-label-floating" ID="Label5" runat="server" Text="Apellido 2"  ReadOnly="true"></asp:Label>
                        <asp:TextBox  class="form-control" ID="txtApellido2" runat="server"></asp:TextBox>
                             </div>
                                </div>
                           <div class="col-md-3">
                          <div class="form-group">
                        <asp:Label class="bmd-label-floating"  ID="Label6" runat="server" Text="Correo"  ReadOnly="true"></asp:Label>
                        <asp:TextBox  class="form-control" ID="txtCorreo" runat="server"></asp:TextBox>
                             </div>
                              </div>
                          <div class="col-md-3">
                          <div class="form-group">
                        <asp:Label class="bmd-label-floating" ID="Label9" runat="server" Text="Telefono"  ReadOnly="true"></asp:Label>
                        <asp:TextBox  class="form-control" ID="TXTTelefono" runat="server"></asp:TextBox>
                             </div>
                              </div>
                            </div>
                 
               <p class="card-category">Datos  transportistas</p>
                        <asp:ScriptManager ID="ScriptManager2" runat="server">
                    </asp:ScriptManager>
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                             <div class="row">
                      <div class="col-md-12">
                        <div class="form-group">
                           <asp:DropDownList ID="dllTransportista" runat="server" class="form-control" style="color:burlywood" AutoPostBack="true" OnSelectedIndexChanged="dllTransportista_SelectedIndexChanged">
                               <asp:ListItem>---Seleccione el transportista</asp:ListItem>
                           </asp:DropDownList>
                        </div>
                      </div>
                         </div> 
                    <div class="row">
                    <div class="form-group">
                        <asp:TextBox  class="form-control" ID="txtTrasportista" runat="server" hidden=""></asp:TextBox>
                    </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <asp:Label class="bmd-label-floating"  ID="Label12" runat="server" Text="Nombre  transportistas"  ReadOnly="true"></asp:Label>
                        <asp:TextBox  class="form-control" ID="txtNombreTrasportista" runat="server"></asp:TextBox>
                    </div>
                    </div>
                   
                      <div class="col-md-6">
                          <div class="form-group">
                        <asp:Label class="bmd-label-floating" ID="Label13" runat="server" Text="Apellido 1"  ReadOnly="true"></asp:Label>
                        <asp:TextBox  class="form-control" ID="txtApellido1Trasportista" runat="server"></asp:TextBox>
                          </div>
                           </div>  
                           </div>  

                        <div class="row">
                          <div class="col-md-6">
                          <div class="form-group">
                        <asp:Label class="bmd-label-floating" ID="Label16" runat="server" Text="Telefono"  ReadOnly="true"></asp:Label>
                        <asp:TextBox  class="form-control" ID="txtTelefonoTras" runat="server"></asp:TextBox>
                             </div>
                              </div>
                            <div class="col-md-6">
                          <div class="form-group">
                        <asp:Label class="bmd-label-floating" ID="Label14" runat="server" Text="Apellido 2"  ReadOnly="true"></asp:Label>
                        <asp:TextBox  class="form-control" ID="txtApellido2Trasportista" runat="server"></asp:TextBox>
                             </div>
                                </div> 
                        </div>
                            
                        </ContentTemplate>
                    </asp:UpdatePanel>
                        <hr />
               <p class="card-category">Datos Vendedor</p>
                    <div class="row">
                    <div class="form-group">
                        <asp:TextBox  class="form-control" ID="TxtCedulaVendedor" runat="server" hidden="true"></asp:TextBox>
                    </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <asp:Label class="bmd-label-floating"  ID="Label17" runat="server" Text="Nombre Vendedor"  ReadOnly="true"></asp:Label>
                        <asp:TextBox  class="form-control" ID="TxtNombreVendedor" runat="server"></asp:TextBox>
                    </div>
                    </div>
                   
                      <div class="col-md-6">
                          <div class="form-group">
                        <asp:Label class="bmd-label-floating" ID="Label18" runat="server" Text="Apellido 1"  ReadOnly="true"></asp:Label>
                        <asp:TextBox  class="form-control" ID="TxtApellido1Vendedor" runat="server"></asp:TextBox>
                          </div>
                           </div>
                                </div>
                           <div class="row">
                         <div class="col-md-6">
                          <div class="form-group">
                        <asp:Label class="bmd-label-floating" ID="Label19" runat="server" Text="Apellido 2"  ReadOnly="true"></asp:Label>
                        <asp:TextBox  class="form-control" ID="TxtApellido2Vendedor" runat="server"></asp:TextBox>
                             </div>
                                </div>
                          <div class="col-md-6">
                          <div class="form-group">
                        <asp:Label class="bmd-label-floating" ID="Label21" runat="server" Text="Telefono"  ReadOnly="true"></asp:Label>
                        <asp:TextBox  class="form-control" ID="TxtTelefonoVendedor" runat="server"></asp:TextBox>
                             </div>
                              </div>
                           </div>
                           
                  <p class="card-category">Datos Productos</p>
                         <div class="row">
                        <div class="col-md-12">
                            <asp:GridView ID="gvProductos" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="561px">
                                <Columns>
                                    <asp:BoundField DataField="ID_PRODUCTO" HeaderText="Nombre" SortExpression="Nombre" />
                                    <asp:BoundField DataField="NOMBRE_PRODUCTO" HeaderText="Primer apellido" SortExpression="Apellido" />
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

                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                             <div class="row">
                      <div class="col-md-4">
                        <div class="form-group">
                           <asp:DropDownList ID="dllProvincia" runat="server" class="form-control" style="color:burlywood" AutoPostBack="true" OnSelectedIndexChanged="dllProvincia_SelectedIndexChanged">
                               <asp:ListItem>----Provincia</asp:ListItem>
                           </asp:DropDownList>
                        </div>
                      </div>
                      <div class="col-md-4">
                        <div class="form-group">
                          <asp:DropDownList ID="dllCanton" runat="server" class="form-control" style="color:burlywood" AutoPostBack="true" OnSelectedIndexChanged="dllCanton_SelectedIndexChanged">
                              <asp:ListItem>----Cantón</asp:ListItem>
                          </asp:DropDownList>
                        </div>
                      </div>
                         <div class="col-md-4">
                        <div class="form-group">
                          <asp:DropDownList ID="dllDistrito" runat="server" class="form-control" style="color:burlywood" AutoPostBack="true">
                              <asp:ListItem>----Distrito</asp:ListItem>
                          </asp:DropDownList>
                        </div>
                      </div>
                                  </div> 
                        </ContentTemplate>
                    </asp:UpdatePanel>
                     <br />
                    
               
                    <div class="row">
                      <div class="col-md-12">
                        <div class="form-group">
                          <label>Detalle Entrega</label>
                            <label class="bmd-label-floating"> </label>
                            <asp:TextBox ID="txtDetalleEntrega" runat="server" TextMode="MultiLine" class="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="validarDetalle" runat="server" ErrorMessage="*" ControlToValidate="txtDetalleEntrega"></asp:RequiredFieldValidator>
                        </div>
                      </div>
                        </div>
                     <div class="row">
                        <div class="col-md-6">
                           <div class="form-group">
                        <asp:Label class="bmd-label-floating" ID="Label7" runat="server" Text="Codigo Pago"></asp:Label>
                         <asp:DropDownList ID="dllPago" runat="server" class="form-control" style="color:burlywood">
                             <asp:ListItem>---Tipo de pago</asp:ListItem>
                         </asp:DropDownList>
                            </div>
                     </div>
                      <div class="col-md-6">
                           <div class="form-group">
                        <asp:Label class="bmd-label-floating" ID="Label8" runat="server" Text="Total"></asp:Label>
                        <asp:TextBox  class="form-control" ID="txtTOTAL" runat="server"></asp:TextBox>
                    </div>
                     </div>
                    </div>        
                    <asp:Button ID="btnFactura" runat="server" Text="Realizar Compra" OnClick="btnFactura_Click" CssClass="btn btn-success" />
                    
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