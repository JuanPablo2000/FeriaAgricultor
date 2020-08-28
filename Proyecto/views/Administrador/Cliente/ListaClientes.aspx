<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="ListaClientes.aspx.cs" Inherits="Proyecto.views.Administrador.Cliente.ListaClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="content">
        <div class="container-fluid">
          <div class="row">
            <div class="col-md-12">
              <div class="card">
                <div class="card-header card-header-primary">
                  <h4 class="card-title ">Clientes</h4>
                  <p class="card-category"> Selecciones solo un vendedor para su compra</p>
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
                            <asp:Button ID="btnCrearCliente" runat="server" Text="Registrar Cliente" CssClass=" btn btn-success" OnClick="btnCrearCliente_Click" />
                            <asp:GridView ID="gvClientes" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="862px" OnRowCommand="gvClientes_RowCommand">

                                <Columns>
                                    <asp:BoundField DataField="CEDULA" HeaderText="Cedula" SortExpression="CEDULA" />
                                    <asp:BoundField DataField="NOMBRE" HeaderText="Nombre" SortExpression="NOMBRE" />
                                    <asp:BoundField DataField="APELLIDO1" HeaderText="Primer apellido" SortExpression="APELLIDO1" />
                                    <asp:BoundField DataField="TELEFONO" HeaderText="Teléfono" SortExpression="TELEFONO" />
                                    <asp:BoundField DataField="USUARIO" HeaderText="Usuario" SortExpression="USUARIO" />
                                    <asp:BoundField DataField="DISTRITO.NOMBRE_DISTRITO" HeaderText="Distrito" SortExpression="ID_DISTRITO" />
                                    <asp:BoundField DataField="CONTRASENA" HeaderText="Contraseña" SortExpression="CONTRASENA" />
                                    <asp:TemplateField HeaderText="Editar">
                                        <ItemTemplate>
                                            <a href="<%# Eval("CEDULA","Edit.aspx?CEDULA={0}") %>" class="btn btn-primary">Editar Cliente</a>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Eliminar">
                                        <ItemTemplate>
                                            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CausesValidation="false" CommandName="Eliminar" CommandArgument='<%# Eval("CEDULA") %>' class="btn btn-danger" />
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
