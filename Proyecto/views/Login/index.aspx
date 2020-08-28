<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Proyecto.views.Login.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <title>Feria</title>
    <link href="../../css/estilos.css" rel="stylesheet" />
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.0.0.min.js"></script>
    <script src="../../Scripts/bootstrap.bundle.min.js"></script>
    <script src="../../Scripts/popper.min.js"></script>
</head>
<body>
        <div class="container">
            <div class="row justify-content-center pt-5 mt-5 mt-1">
                <div class="col-md-4 formulario">
                    <form id="form1" runat="server">
                        <div class="form-group text-center pt-3">
                            <h1 class="">Iniciar Sesión</h1>
                        </div>
                     <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:Panel ID="pnlMensaje" runat="server" Visible="false">
                                <div class="alert alert-danger" role="alert">
                                    <strong>Atención!</strong> Se ha presentado el siguiente problema.
                                    <br />
                                    <br />
                                    <asp:BulletedList ID="blMensajes" runat="server"></asp:BulletedList>
                                </div>
                            </asp:Panel>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                        <div class="form-group mx-sm-4 pt-3">
                            <asp:TextBox ID="txtUsuario" runat="server" class="form-control" placeholder="Usuario"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="validarUsuario" runat="server" ErrorMessage="*" ControlToValidate="txtUsuario" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>

                         <div class="form-group mx-sm-4 pb-3">
                            <asp:TextBox ID="txtContraseña" runat="server" class="form-control" TextMode="Password" placeholder="Contraseña"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="validarContrasena" runat="server" ErrorMessage="*" ControlToValidate="txtContraseña" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                        
                        <div class="form-group mx-sm-4 pb-5">
                            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass=" btn btn-block ingresar" OnClick="btnIngresar_Click" />
                        </div>

                        <div class="form-group text-center">
                            <asp:LinkButton ID="LinkButton1" runat="server" CssClass="registrar" OnClick="LinkButton1_Click" CausesValidation="False">Registrarse</asp:LinkButton>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    
</body>
</html>
