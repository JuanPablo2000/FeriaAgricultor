﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Proyecto.views.Administrador.Vendedor.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="content">
        <div class="container-fluid">
          <div class="row">
            <div class="col-md-12">
              <div class="card">
                <div class="card-header card-header-primary">
                  <h4 class="card-title ">Vendedor</h4>
                  <p class="card-category"> Ingrese información en los campos de texto</p>
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

    <div class="row">
        <div class="col-md-5">
            <div class="form-group">
                <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre" class="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="validarNombre" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="ExpresionNombre" runat="server" ErrorMessage="Solo se permiten letras" ControlToValidate="txtNombre" Display="Dynamic" ValidationExpression="^[a-zA-Z][a-zA-Z0-9]*$"></asp:RegularExpressionValidator>

            </div>
        </div>
        <div class="col-md-3">
            <div class="form-group">
                <asp:TextBox ID="txtApellido1" runat="server" placeholder="Primer Apellido" class="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="ValidarApellido1" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtApellido1"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="ExpresionApellido1" runat="server" ErrorMessage="Solo se permiten letras" Display="Dynamic" ControlToValidate="txtApellido1" ValidationExpression="^[a-zA-Z][a-zA-Z0-9]*$"></asp:RegularExpressionValidator>

            </div>
        </div>
        <div class="col-md-4">
            <div class="form-group">
                <asp:TextBox ID="txtApellido2" runat="server" placeholder="Segundo Apellido" class="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="validarApellido2" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtApellido2"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="ExpresionApellido2" runat="server" ErrorMessage="Solo se permiten letras" Display="Dynamic" ControlToValidate="txtApellido2" ValidationExpression="^[a-zA-Z][a-zA-Z0-9]*$"></asp:RegularExpressionValidator>

            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6">
            <div class="form-group">
                <asp:TextBox ID="txtIdentificacion" runat="server" placeholder="Identificación" class="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="validarIdentificacion" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtIdentificacion"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="expresesionIdentificacon" runat="server" ErrorMessage="Solo se permiten numeros o letras" Display="Dynamic" ControlToValidate="txtIdentificacion" ValidationExpression="^[a-zA-Z][a-zA-Z0-9]*$"></asp:RegularExpressionValidator>

            </div>
        </div>
        <div class="col-md-6">
            <div class="form-group">
                <asp:TextBox ID="txtEmail" runat="server" placeholder="Correo Electronico" class="form-control" TextMode="Email"></asp:TextBox>
                <asp:RequiredFieldValidator ID="validarEmail" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>

            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <div class="form-group">
                <asp:TextBox ID="txtTelefono" runat="server" placeholder="Télefono" class="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="validarTelefono" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtTelefono"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="expresionTelefono" runat="server" ErrorMessage="Solo se permiten numeros " Display="Dynamic" ControlToValidate="txtTelefono" ValidationExpression="^([0-9])*$"></asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="col-md-4">
            <div class="form-group">
                <asp:TextBox ID="txtUsuario" runat="server" placeholder="Usuario" class="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtUsuario"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="col-md-4">
            <div class="form-group">
                <asp:TextBox ID="txtContraseña" runat="server" placeholder="Contraseña" class="form-control" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtContraseña"></asp:RequiredFieldValidator>
            </div>
        </div>
    </div>
    <asp:ScriptManager ID="ScriptManager2" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <div class="row">
                <div class="col-md-3">
                    <div class="form-group">
                        <asp:DropDownList ID="dllTipoPago" runat="server" class="form-control" Style="color: burlywood" >
                            <asp:ListItem>----Tipo pago</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="form-group">
                        <asp:DropDownList ID="dllProvincia" runat="server" class="form-control" Style="color: burlywood" AutoPostBack="True" OnSelectedIndexChanged="dllProvincia_SelectedIndexChanged">
                            <asp:ListItem>----Provincia</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="form-group">
                        <asp:DropDownList ID="dllCanton" runat="server" class="form-control" Style="color: burlywood" AutoPostBack="True" OnSelectedIndexChanged="dllCanton_SelectedIndexChanged">
                            <asp:ListItem>----Cantón</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="form-group">
                        <asp:DropDownList ID="dllDistrito" runat="server" class="form-control" Style="color: burlywood" AutoPostBack="True">
                            <asp:ListItem>----Distrito</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                
    <br />
    <asp:Button runat="server" Text="Crear Cliente" class="btn btn-primary pull-right" OnClick="btnCrear" />
        </ContentTemplate>
    </asp:UpdatePanel>
                            </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
