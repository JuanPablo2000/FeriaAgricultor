<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipalVendedor.Master" AutoEventWireup="true" CodeBehind="EditVendedor.aspx.cs" Inherits="Proyecto.views.Vendedor.EditVendedor" %>
<asp:content id="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="text-center text-gray">
          <a href="EditVendedor.aspx" class="text-center">
               <i class="material-icons">create</i>
               <asp:Label ID="Label1" class="nombreuser text-center text-white " runat="server" ></asp:Label>
          </a> 
    </div>
</asp:content>
<asp:Content id="Content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <div class="text-center text-gray">
          <a href="../Vendedor/VendedorDashboard.aspx" class="text-center">
               <i class="material-icons">fact_check</i>    
              <label class="text-white font-weight-light">Gestionar Productos</label>
    </a>         
    </div>
</asp:Content>
<asp:content id="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
   
        <div class="row">
            <div class="col-md-12">
              <div class="card">
                <div class="card-header card-header-primary">
                  <h4 class="card-title">Edita Perfil</h4>
                  <p class="card-category">Informacion Personal</p>
                </div>
                <div class="card-body">
                    <div class="row">
                      <div class="col-md-5">
                        <div class="form-group">
                          <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre" class="form-control" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="validarNombre" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="ExpresionNombre" runat="server" ErrorMessage="Solo se permiten letras" ControlToValidate="txtNombre" Display="Dynamic" ValidationExpression="^[a-zA-Z][a-zA-Z0-9]*$"></asp:RegularExpressionValidator>
                       
                        </div>
                      </div>
                      <div class="col-md-3">
                        <div class="form-group">
                           <asp:TextBox ID="txtApellido1" runat="server" placeholder="Primer Apellido" class="form-control" ></asp:TextBox>
                             <asp:RequiredFieldValidator ID="ValidarApellido1" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtApellido1"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="ExpresionApellido1" runat="server" ErrorMessage="Solo se permiten letras" Display="Dynamic" ControlToValidate="txtApellido1" ValidationExpression="^[a-zA-Z][a-zA-Z0-9]*$"></asp:RegularExpressionValidator>
                       
                        </div>
                      </div>
                      <div class="col-md-4">
                        <div class="form-group">
                       <asp:TextBox ID="txtApellido2" runat="server" placeholder="Segundo Apellido" class="form-control" ></asp:TextBox>
                             <asp:RequiredFieldValidator ID="validarApellido2" runat="server"  ErrorMessage="*" Display="Dynamic" ControlToValidate="txtApellido2"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="ExpresionApellido2" runat="server"  ErrorMessage="Solo se permiten letras" Display="Dynamic" ControlToValidate="txtApellido2" ValidationExpression="^[a-zA-Z][a-zA-Z0-9]*$"></asp:RegularExpressionValidator>
                       
                        </div>
                      </div>
                    </div>
                    <div class="row">
                     
                      <div class="col-md-6">
                        <div class="form-group">
                          <asp:TextBox ID="txtEmail" runat="server" placeholder="Correo Electronico" class="form-control" TextMode="Email"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="validarEmail" runat="server"  ErrorMessage="*" Display="Dynamic" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
                       
                        </div>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-md-12">
                        <div class="form-group">
                         <asp:TextBox ID="txtTelefono" runat="server" placeholder="Télefono" class="form-control" ></asp:TextBox>
                                <asp:RequiredFieldValidator ID="validarTelefono" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtTelefono"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="expresionTelefono" runat="server" ErrorMessage="Solo se permiten numeros " Display="Dynamic" ControlToValidate="txtTelefono" ValidationExpression="^([0-9])*$"></asp:RegularExpressionValidator>
                        </div>
                      </div>
                    </div>
                     <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                     <asp:UpdatePanel ID="UpdatePanel2" runat="server" >
                        <ContentTemplate>
                    <div class="row">
                      <div class="col-md-4">
                        <div class="form-group">
                            <asp:DropDownList ID="dllProvincia" runat="server" class="form-control" style="color:burlywood" placeholder="Provincia" OnSelectedIndexChanged="dllProvincia_SelectedIndexChanged" AutoPostBack="True">
                                <asp:ListItem Value="0">---Provincia</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                      </div>
                      <div class="col-md-4">
                        <div class="form-group">
                           <asp:DropDownList ID="dllCanton" runat="server"  style="color:burlywood" class="form-control" OnSelectedIndexChanged="dllCanton_SelectedIndexChanged" AutoPostBack="true">
                                <asp:ListItem Value="0">---Canton</asp:ListItem>
                           </asp:DropDownList>
                        </div>
                      </div>
                         <div class="col-md-4">
                        <div class="form-group">
                          <asp:DropDownList ID="dllDistrito" runat="server"  style="color:burlywood" class="form-control" placeholder="Provincia">
                                 <asp:ListItem Value="0">---Distrito</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                      </div>
                     <br />
                        <asp:Button runat="server" Text="Editar"  class="btn btn-primary pull-right" OnClick="btnEditar" />
                </div> 
                            </ContentTemplate>
                         </asp:UpdatePanel>
              </div>
              </div>
              </div>
              </div>
</asp:Content>
