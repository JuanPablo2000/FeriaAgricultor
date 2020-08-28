<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="ListaFacturas.aspx.cs" Inherits="Proyecto.views.Administrador.Cliente.ListaFacturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="content">
        <div class="container-fluid">
          <div class="row">
            <div class="col-md-12">
              <div class="card">
                <div class="card-header card-header-primary">
                  <h4 class="card-title ">Facturacion</h4>
                  <p class="card-category"> Selecciones la factura que desea eliminar</p>
                </div>
                <div class="card-body">
                            <asp:Panel ID="pnlMensaje" runat="server" Visible="false">
                                <div class="alert alert-danger" role="alert">
                                    <strong>Atención!</strong> Se ha presentado el siguiente problema.
                                    <br />
                                    <br />
                                    <asp:BulletedList ID="blMensajes" runat="server"></asp:BulletedList>
                                </div>
                            </asp:Panel>
                    <asp:GridView ID="gvFacturas" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="862px" OnRowCommand="gvFacturas_RowCommand" >

                                <Columns>
                                      <asp:BoundField DataField="ID_FACTURACION" HeaderText="Código Factura" SortExpression="ID_FACTURACION" />
                                    <asp:BoundField DataField="FECHA" HeaderText="Fecha" SortExpression="Fecha" />
                                    <asp:BoundField DataField="ID_VENDEDOR" HeaderText="Vendedor Identificación" SortExpression="Vendedor" />
                                    <asp:BoundField DataField="DIRECCION_ENTREGA" HeaderText="Dirección entrega" SortExpression="Direccion entrega" />
                                    <asp:BoundField DataField="ID_TRANSPORTISTA" HeaderText="Transportista identificación" SortExpression="Transportista identificacion" />
                                    <asp:BoundField DataField="DETALLE_ENTREGA" HeaderText="Detalle Entrega" SortExpression="Detalle entrega" />
                                    <asp:BoundField DataField="ID_PRODUCTO" HeaderText="Codigo Producto" SortExpression="Codigo producto" />
                                    <asp:BoundField DataField="TOTAL" HeaderText="Monto total" SortExpression="monto total" />
                                    <asp:TemplateField HeaderText="Eliminar">
                                        <ItemTemplate>
                                            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CausesValidation="false" CommandName="Eliminar" CommandArgument='<%# Eval("ID_FACTURACION") %>' class="btn btn-danger" />
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