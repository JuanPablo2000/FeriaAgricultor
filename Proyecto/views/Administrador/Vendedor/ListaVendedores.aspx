<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="ListaVendedores.aspx.cs" Inherits="Proyecto.views.Administrador.Vendedor.ListaVendedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="content">
        <div class="container-fluid">
          <div class="row">
            <div class="col-md-12">
              <div class="card">
                <div class="card-header card-header-primary">
                  <h4 class="card-title ">Vendedores</h4>
                  <p class="card-category"> Selecciones la acción que desea realizar</p>
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
                            <asp:Button ID="btnCrearVendedor" runat="server" Text="Registrar Vendedor" CssClass=" btn btn-success" OnClick="btnCrearVendedor_Click" />
                           <asp:GridView ID="gvVendedor" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="16px" OnRowCommand="gvVendedor_RowCommand">
                               <Columns>
                                    <asp:BoundField DataField="CEDULA" HeaderText="Cedula" SortExpression="CEDULA" />
                                    <asp:BoundField DataField="NOMBRE" HeaderText="Nombre" SortExpression="NOMBRE" />
                                    <asp:BoundField DataField="APELLIDO1" HeaderText="Apellido 1" SortExpression="APELLIDO1" />
                                    <asp:BoundField DataField="TELEFONO" HeaderText="Telefóno" SortExpression="TELEFONO" />
                                    <asp:BoundField DataField="USUARIO" HeaderText="Usuario" SortExpression="USUARIO" />
                                    <asp:BoundField DataField="CONTRASENA" HeaderText="Contraseña" SortExpression="CONTRASENA" />
                                    <asp:BoundField DataField="HABILITADO" HeaderText="Estado" SortExpression="HABILITAD0" />

                                    <asp:TemplateField HeaderText="ESTADO">
                                        <ItemTemplate>
                                         <asp:Button ID="btntrue" runat="server" Text="Habilitar" CausesValidation="false" CommandName="Habilitar" CommandArgument='<%# Eval("CEDULA") %>' class="btn btn-success" />
                                        <asp:Button ID="btnFalse" runat="server" Text="Desabilitar" CausesValidation="false" CommandName="Desabilitatr" CommandArgument='<%# Eval("CEDULA") %>' class="btn btn-danger" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                   <asp:TemplateField HeaderText="Editar">
                                    <ItemTemplate>
                                         <a href="<%# Eval("CEDULA","Editar.aspx?CEDULA={0}") %>" class="btn btn-primary">Modificar</a>
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
