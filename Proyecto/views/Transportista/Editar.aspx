<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="Proyecto.views.Transportista.Editar" %>

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
            <a class="nav-link" href="../../views/Transportisra/Editar.aspx">
              <i class="material-icons">create</i>
              <p style="color: white">Perfil</p>
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
                 <h4 class="card-title">Transportista</h4>
                                    <p class="card-category">Ingrese la Siguiente Informacion</p>
                                </div>
                                <div class="card-body">
                                    <form runat="server">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <div class="form-group">
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
                                                    <!--Cedula-->
                                                    <asp:Label ID="lblCedula" runat="server" Text="Cédula:" class="control-label col-md-2" ></asp:Label>
                                                    <div class="col-md-10">
                                                        <asp:TextBox ID="tbCedula" runat="server" class="form-control" ReadOnly="true" Style="color: black"></asp:TextBox>
                                                     </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-4">
                                                <div class="form-group">
                                                    <!--Nombre-->
                                                    <asp:Label ID="lblNombre" runat="server" Text="Nombre:" class="control-label col-md-2"></asp:Label>
                                                    <div class="col-md-10">
                                                        <asp:TextBox ID="tbNombre" runat="server" class="form-control" ></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="RFNombre" runat="server" ErrorMessage="Este campo es requerido" ControlToValidate="tbNombre"></asp:RequiredFieldValidator>
                                                        <asp:RegularExpressionValidator ID="REVNombre" runat="server" ErrorMessage="Este campo no permite numeros" ValidationExpression="^[a-zA-Z][a-zA-Z0-9]*$" ControlToValidate="tbNombre"></asp:RegularExpressionValidator>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-4">
                                                <div class="form-group">
                                                    <!--Apellido1-->
                                                    <asp:Label ID="lblApellido1" runat="server" Text="Primer Apellido:" class="control-label col-md-2"></asp:Label>
                                                    <div class="col-md-10">
                                                        <asp:TextBox ID="tbApellido1" runat="server" class="form-control"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="RFApellido1" runat="server" ErrorMessage="Este campo es requerido" ControlToValidate="tbApellido1"></asp:RequiredFieldValidator>
                                                        <asp:RegularExpressionValidator ID="REVApellido1" runat="server" ErrorMessage="Este campo no permite numeros" ValidationExpression="^[a-zA-Z][a-zA-Z0-9]*$" ControlToValidate="tbApellido1"></asp:RegularExpressionValidator>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-4">
                                                <div class="form-group">
                                                    <!--Apellido2-->
                                                    <asp:Label ID="lblApellido2" runat="server" Text="Segundo Apellido:" class="control-label col-md-2" ReadOnly="true"></asp:Label>
                                                    <div class="col-md-10">
                                                        <asp:TextBox ID="tbApellido2" runat="server" class="form-control"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="RFApellido2" runat="server" ErrorMessage="Este campo es requerido" ControlToValidate="tbApellido2"></asp:RequiredFieldValidator>
                                                        <asp:RegularExpressionValidator ID="REVApellido2" runat="server" ErrorMessage="Este campo no permite numeros" ValidationExpression="^[a-zA-Z][a-zA-Z0-9]*$" ControlToValidate="tbApellido2"></asp:RegularExpressionValidator>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <div class="form-group">
                                                    <!--Correo-->
                                                    <asp:Label ID="lblCorreo" runat="server" Text="Correo Electronico:" class="control-label col-md-2"></asp:Label>
                                                    <div class="col-md-10">
                                                        <asp:TextBox ID="tbCorreo" runat="server" class="form-control"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="RFCorreo" runat="server" ErrorMessage="Este campo es requerido" ControlToValidate="tbCorreo"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-6">
                                                <div class="form-group">
                                                    <!--Telefono-->
                                                    <asp:Label ID="lblTelefono" runat="server" Text="Telefono:" class="control-label col-md-2"></asp:Label>
                                                    <div class="col-md-10">
                                                        <asp:TextBox ID="tbTelefono" runat="server" class="form-control"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="RFTelefono" runat="server" ErrorMessage="Este campo es requerido" ControlToValidate="tbTelefono"></asp:RequiredFieldValidator>
                                                        <asp:RegularExpressionValidator ID="REVTelefono" runat="server" ErrorMessage="Este campo no permite letras" ValidationExpression="^[0-9]{0,25}$" ControlToValidate="tbTelefono"></asp:RegularExpressionValidator>
                                                        <asp:CompareValidator ID="CVTelefono" runat="server" ErrorMessage="Este campo solo permite datos enteros" Operator="DataTypeCheck" SetFocusOnError="true" Type="Integer" ControlToValidate="tbTelefono"></asp:CompareValidator>
                                                    </div>
                                                    </div>
                                                </div>
                                            </div>
                             <asp:ScriptManager ID="ScriptManager2" runat="server">
                            </asp:ScriptManager>
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                <div class="row">
                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <asp:Label ID="Label1" runat="server" Text="Provincia:" class="control-label col-md-2"></asp:Label>
                                            <asp:DropDownList ID="dllProvincia" runat="server" AutoPostBack="True" style="color:burlywood" CssClass="form-control" OnSelectedIndexChanged="dllProvincia_SelectedIndexChanged"></asp:DropDownList>
                                        </div>
                                    </div>
                                     <div class="col-md-4">
                                        <div class="form-group">
                                            <asp:Label ID="Label2" runat="server" Text="Cantón:" class="control-label col-md-2"></asp:Label>
                                            <asp:DropDownList ID="dllCanton" runat="server" AutoPostBack="True" style="color:burlywood" class="form-control" OnSelectedIndexChanged="dllCanton_SelectedIndexChanged"></asp:DropDownList>
                                        </div>
                                    </div>
                                     <div class="col-md-4">
                                        <div class="form-group">
                                            <asp:Label ID="Label3" runat="server" Text="Distrito:" class="control-label col-md-2"></asp:Label>
                                            <asp:DropDownList ID="dllDistrito" runat="server" style="color:burlywood" AutoPostBack="True" class="form-control"></asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                                <div class="row">
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <!--Tipo de Licencia-->
                                            <div class="col-md-10">
                                                <asp:Label ID="Label4" runat="server" Text="Licencía:" class="control-label col-md-2"></asp:Label>
                                                <asp:TextBox ID="tbTiLic" runat="server" class="form-control"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RFtbTiLic" runat="server" ErrorMessage="Este campo es requerido" ControlToValidate="tbTiLic"></asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator ID="REVtbTiLic" runat="server" ErrorMessage="Se requieren datos alfanumericos" ValidationExpression="^[a-z A-Z][0-9]{0,25}$" ControlToValidate="tbTiLic"></asp:RegularExpressionValidator>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-md-6">
                                        <div class="form-group">
                                           <asp:Label ID="Label5" runat="server" Text="Tipo vehiculo:" class="control-label col-md-2"></asp:Label>
                                            <div class="col-md-10">
                                                 <asp:DropDownList ID="dllVehiculo" runat="server" style="color:burlywood" CssClass="form-control"></asp:DropDownList>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-3">
                                        <div class="form-group">
                                          <asp:Label ID="Label6" runat="server" Text="Placa:" class="control-label col-md-2"></asp:Label>
                                            <div class="col-md-10">
                                                <asp:TextBox ID="txtPlaca" runat="server" class="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-md-3">
                                        <div class="form-group">
                                            <asp:Label ID="Label7" runat="server" Text="Marca:" class="control-label col-md-2"></asp:Label>
                                            <div class="col-md-10">
                                                <asp:TextBox ID="txtMarca" runat="server" class="form-control"></asp:TextBox>
                                             </div>
                                        </div>
                                    </div>
                                    <div class="col-md-3">
                                        <div class="form-group">
                                            <asp:Label ID="Label8" runat="server" Text="Modelo:" class="control-label col-md-2"></asp:Label>
                                            <div class="col-md-10">
                                                <asp:TextBox ID="txtModelo" runat="server" class="form-control"></asp:TextBox>
                                             </div>
                                        </div>
                                    </div>
                                    <div class="col-md-3">
                                        <div class="form-group">
                                          <asp:Label ID="Label9" runat="server" Text="Color:" class="control-label col-md-2"></asp:Label>
                                            <div class="col-md-10">
                                                <asp:TextBox ID="txtCOLor" runat="server" class="form-control"></asp:TextBox>
                                             </div>
                                        </div>
                                    </div>
                                </div>
                        <asp:Button ID="btnCrear" runat="server" Text="Editar Perfil" class="btn btn-primary " OnClick="btnEditar_Click"  />
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar Perfil" class="btn btn-danger " OnClick="btnEliminar_Click" />
                            </form>             
                        </div>
                  
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
