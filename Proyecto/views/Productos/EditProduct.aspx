<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipalVendedor.Master" AutoEventWireup="true" CodeBehind="EditProduct.aspx.cs" Inherits="Proyecto.views.Productos.EditProduct" %>

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
    <div class="card-header text-center text-info bg-dark rounded">
                  <h4 class="card-title text-info">Editar tu Producto</h4>
                  <p class="card-category text-gray">Completa la información</p>
                </div>
    <div class="bg-dark rounded p-3 ">
        <div class="form-group w-50 m-auto">
            <asp:HiddenField ID="idproducto" runat="server" />
      <label class="text-info">Nombre Producto:</label>
   <asp:TextBox ID="txtNombreProducto"  runat="server" class="form-control text-center" ReadOnly="true"></asp:TextBox>
           
                       
  </div>
 
  <div class="form-group w-50 m-auto">
     <label for="txtNombre" class="text-info">Precio x Kilo:</label>
 <asp:TextBox ID="PrecioKilo" runat="server" class="form-control text-center"></asp:TextBox>
       <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo requerido" Display="Dynamic" ControlToValidate="PrecioKilo"></asp:RequiredFieldValidator>
       <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Solo se permiten numeros" ControlToValidate="PrecioKilo" Display="Dynamic" ValidationExpression="[0-9]+([\.][0-9]{0,2})?"></asp:RegularExpressionValidator>
  </div>
      <div class="form-group w-50 m-auto">
      <label  class="text-info">Precio x Unidad:</label>
 <asp:TextBox ID="PrecioUnidad" runat="server" class="form-control text-center" ></asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo requerido" Display="Dynamic" ControlToValidate="PrecioUnidad"></asp:RequiredFieldValidator>
       <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Solo se permiten numeros" ControlToValidate="PrecioUnidad" Display="Dynamic" ValidationExpression="[0-9]+([\.][0-9]{0,2})?"></asp:RegularExpressionValidator>
  </div>
<div class="form-group w-50 m-auto d-flex flex-row-reverse">
   <asp:Button ID="btnEditProuct" runat="server" Text="Editar Producto" class="btn btn-success d-flex " OnClick="btnEditProuct_Click" />
  </div>

        
     
 <asp:TextBox ID="id_vendedor" runat="server" class="form-control text-center text-dark disabled"></asp:TextBox>
  
    </div>
  



</asp:Content>
