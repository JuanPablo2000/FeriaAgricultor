<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipalCliente.Master" AutoEventWireup="true" CodeBehind="CompraProductos.aspx.cs" Inherits="Proyecto.views.Cliente.CompraProductos" %>

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
                            <p class="card-category">Selecciones solo un vendedor para su compra</p>
                        </div>
                        <div class="card-body">
                <asp:ScriptManager ID="ScriptManager2" runat="server">
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
                            <asp:HiddenField ID="id_vendedor" runat="server" />
                            <asp:GridView ID="gvProducto" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
                                <Columns>
                                    <asp:TemplateField HeaderText="Seleccionar">
                                        <ItemTemplate>
                                            <asp:CheckBox ID="CheckSeleccionado" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="ID_PRODUCTO" HeaderText="Codigo" SortExpression="codigo" />
                                    <asp:BoundField DataField="NOMBRE_PRODUCTO" HeaderText="Nombre" SortExpression="Nombre" />
                                    <asp:BoundField DataField="PRECIO_KILO" HeaderText="Precio por Kilo" SortExpression="Precio Kilo" />
                                    <asp:BoundField DataField="PRECIO_UNIDAD" HeaderText="Precio por Unidad" SortExpression="Precio unidad" />
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:TextBox ID="kilo" runat="server" name="kilo" placeholder="Cantidad por kilo"></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="expresionCantidadKilo" runat="server" ErrorMessage="Solo se permite numeros" Display="Dynamic" ControlToValidate="kilo" ValidationExpression="^([0-9])*$"></asp:RegularExpressionValidator>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:TextBox ID="unidad" runat="server" name="unidad" placeholder="Cantidad por Unidad"></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="ExpresionCantidadUnidad" runat="server" ErrorMessage="Solo se permite numeros" Display="Dynamic" ControlToValidate="unidad" ValidationExpression="^([0-9])*$"></asp:RegularExpressionValidator>
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
                            <div class="form-group float-center">
                                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                    <ContentTemplate>
                                        <asp:TextBox ID="txtTotal" runat="server" placeholder="Monto total" class="form-control"></asp:TextBox>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                                <asp:Button ID="btnCalcular" runat="server" Text="Calcular Monto" class="btn btn-info" OnClick="btnCalcular_Click" CausesValidation="False" />
                                <asp:Button ID="btnComprar" runat="server" Text="Comprar" class="btn btn-success" OnClick="btnComprar_Click" />
                            </div>
                          </div>
                    </div>
                </div>
            </div>
        </div>
        </div>
</asp:Content>
