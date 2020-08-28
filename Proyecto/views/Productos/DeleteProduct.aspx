<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipalVendedor.Master" AutoEventWireup="true" CodeBehind="DeleteProduct.aspx.cs" Inherits="Proyecto.views.Productos.DeleteProduct" %>

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
                  <h4 class="card-title text-info">Eliminar Productoo</h4>
                  <p class="card-category text-gray">Al presionar el boton se eliminará el producto seleccionado</p>
                </div>
    <div class="bg-dark rounded p-3 ">
        <div class="form-group w-50 m-auto">
            <asp:HiddenField ID="idproducto" runat="server" />
      <label class="text-info">Nombre Producto:</label>
   <asp:TextBox ID="txtNombreProducto"  runat="server" class="form-control text-center disabled"></asp:TextBox>
  </div>
 
  <div class="form-group w-50 m-auto">
     <label for="txtNombre" class="text-info">Precio x Kilo:</label>
 <asp:TextBox ID="PrecioKilo" runat="server" class="form-control text-center disabled"></asp:TextBox>
  </div>
      <div class="form-group w-50 m-auto">
      <label  class="text-info">Precio x Unidad:</label>
 <asp:TextBox ID="PrecioUnidad" runat="server" class="form-control text-center disabled"></asp:TextBox>
  </div>
<div class="form-group w-50 m-auto d-flex flex-row-reverse">
   <asp:Button ID="btnEditProuct" runat="server" Text="Eliminar Producto" class="btn btn-danger d-flex " OnClick="btndeleteproduct_Click" />
  </div>

        
     
 <asp:TextBox ID="id_vendedor" runat="server" class="form-control text-center text-dark disabled"></asp:TextBox>
  
    </div>
</asp:Content>
