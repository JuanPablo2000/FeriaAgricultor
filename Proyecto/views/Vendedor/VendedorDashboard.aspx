<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipalVendedor.Master" AutoEventWireup="true" CodeBehind="VendedorDashboard.aspx.cs" Inherits="Proyecto.views.Vendedor.VendedorDashboard" %>
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
          <a href="VendedorDashboard.aspx" class="text-center">
               <i class="material-icons">fact_check</i>    
              <label class="text-white font-weight-light">Gestionar Productos</label>
    </a>
         
    </div>

</asp:Content>
<asp:content id="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
   <div class="content">
        <div class="container-fluid">
          <div class="row">
            <div class="col-md-12">
              <div class="card">
                <div class="card-header card-header-primary">
                  <h4 class="card-title ">Productos</h4>
                  <p class="card-category"> Gestiona Tus productos</p>
                </div>
                <div class="card-body">
                    <asp:HiddenField ID="id_vendedor" runat="server" />
                     <div class="form-group">
                         <asp:Button ID="btnCrea" runat="server" Text="Añadir Producto" class="btn btn-success" OnClick="btnCrea_Click" />
                            </div>
                    <asp:GridView ID="gvProductos" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="895px">
                        
                        <Columns>
                            <asp:BoundField DataField="NOMBRE_PRODUCTO" HeaderText="Producto" SortExpression="Nombre" />
                            <asp:BoundField DataField="PRECIO_KILO" HeaderText="Precio Kilo" SortExpression="Preciokilo" />
                            <asp:BoundField DataField="PRECIO_UNIDAD" HeaderText="Precio Unidad" SortExpression="Apellido" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                     <a href="<%# Eval("ID_PRODUCTO","../Productos/EditProduct.aspx?productid={0}") %>" class="btn btn-warning">Editar Producto</a>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                     <a href="<%# Eval("ID_PRODUCTO","../Productos/DeleteProduct.aspx?productid={0}") %>" class="btn btn-danger">Eliminar Producto</a>
                                </ItemTemplate>
                            </asp:TemplateField>
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
            </div>
           </div>
          </div>
         </div>

</asp:Content>
