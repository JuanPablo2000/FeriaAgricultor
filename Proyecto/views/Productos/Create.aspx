<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipalVendedor.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Proyecto.views.Productos.Create" %>
<asp:content id="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <div class="text-center text-gray">
          <a href="EditVendedor.aspx" class="text-center">
               <i class="material-icons">create</i>
               <asp:Label ID="Label1" class="nombreuser text-center text-white " runat="server" ></asp:Label>
          </a> 
    </div>
</asp:content>
<asp:Content id="Content3" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <div class="text-center text-gray">
          <a href="../Vendedor/VendedorDashboard.aspx" class="text-center">
               <i class="material-icons">fact_check</i>    
              <label class="text-white font-weight-light">Gestionar Productos</label>
    </a>
         
    </div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <asp:HiddenField ID="id_vendedor" runat="server" />
  <div class="card-header card-header-warning bg-dark text-center text-info">
                  <h4 class="card-title text-white">Agregar Nuevo Producto</h4>
                  <p class="card-category">Completa la información</p>
                </div>
    <div class=" bg-dark">
        <div class="card-body">
                    <div class="row">
                      <div class="col-md-5">
                        <div class="form-group">
                                                        <asp:Label runat="server" CssClass="label-on-left text-info">Nombre </asp:Label>
                          <asp:TextBox ID="NombreProduct" runat="server" placeholder="Nombre Producto" class="form-control" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="validarNombre" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="NombreProduct"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="ExpresionNombre" runat="server" ErrorMessage="Solo se permiten letras" ControlToValidate="NombreProduct" Display="Dynamic" ValidationExpression="^[a-zA-Z][a-zA-Z0-9]*$"></asp:RegularExpressionValidator>
                       
                        </div>
                      </div>
                         <div class="col-md-5">
                        <div class="form-group">
                                                        <asp:Label runat="server"  CssClass="label-on-left text-info" >Precio x Kilo</asp:Label>
                          <asp:TextBox ID="PrecioKilo" runat="server" placeholder="Precio Kilogramo" class="form-control" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="PrecioKilo"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Solo se permiten numeros" ControlToValidate="PrecioKilo" Display="Dynamic" ValidationExpression="[0-9]+([\.][0-9]{0,2})?"></asp:RegularExpressionValidator>
                       
                        </div>
                      </div>
                        <div class="col-md-5">
                        <div class="form-group">
                            <asp:Label runat="server"  CssClass="label-on-left text-info">Precio x Unidad</asp:Label>
                          <asp:TextBox ID="PrecioUnidad" runat="server" placeholder="Precio Unidad" class="form-control" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="PrecioUnidad"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Solo se permiten numeros" ControlToValidate="PrecioKilo" Display="Dynamic" ValidationExpression="[0-9]+([\.][0-9]{0,2})?"></asp:RegularExpressionValidator>
                       
                        </div>
                      </div>
                        <div class="col-md-5">
                        <div class="form-group">
                          <asp:Button runat="server" Text="Agregar"  class="btn btn-success pull-right" OnClick="btnSubmitP" />
                            </div>
                            </div>
                        </div>
         </div>
    </div>

</asp:Content>
