<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipalCliente.Master" AutoEventWireup="true" CodeBehind="Vendedores.aspx.cs" Inherits="Proyecto.views.Cliente.Vendedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="content">
        <div class="container-fluid">
          <div class="row">
            <div class="col-md-12">
              <div class="card">
                <div class="card-header card-header-primary">
                  <h4 class="card-title ">Vendedores</h4>
                  <p class="card-category"> Selecciones solo un vendedor para su compra</p>
                </div>
                <div class="card-body">

                    <asp:GridView ID="gvVendedores" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="895px">
                        <Columns>
                            <asp:BoundField DataField="NOMBRE" HeaderText="Nombre" SortExpression="Nombre" />
                            <asp:BoundField DataField="APELLIDO1" HeaderText="Primer apellido" SortExpression="Apellido" />
                            <asp:BoundField DataField="APELLIDO2" HeaderText="Segundo apellido" SortExpression="Apellido" />
                            <asp:BoundField DataField="CORREO" HeaderText="Correo" SortExpression="correo" />
                            <asp:BoundField DataField="TELEFONO" HeaderText="telefono" SortExpression="correo" />
                            <asp:BoundField DataField="COD_PAGO" HeaderText="Codigo Pago" SortExpression="cod_pago" Visible="False" />
                            <asp:BoundField DataField="nombre_pago" HeaderText="Tipo de pago" SortExpression="Tipo" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                     <a href="<%# Eval("CEDULA","../Cliente/CompraProductos.aspx?CEDULA={0}") %>" class="btn btn-success">Seleccionar</a>
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
