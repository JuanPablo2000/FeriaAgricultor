<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="Proyecto.views.Login.registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>FormWizard_v8</title>
		<meta name="viewport" content="width=device-width, initial-scale=1.0"/>
		<link rel="stylesheet" href="../../fonts/material-design-iconic-font/css/material-design-iconic-font.css"/>
		<link rel="stylesheet" href="../../css/style.css"/>
        <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
        <script src="../../Scripts/jquery-3.0.0.min.js"></script>
        <script src="../../Scripts/bootstrap.bundle.min.js"></script>
        <script src="../../Scripts/popper.min.js"></script>
		
	</head>
	<body>
		<div class="wrapper">
            <form  runat="server" id="wizard">
                <asp:HiddenField ID="RolUser" runat="server" />
            
        		<!-- SECTION 1 -->
                <h4></h4>
                <section>
                    <h3>Información Personal</h3>
                	<div class="form-group row">
                        <div class="form-holder col">
                            <i class="zmdi zmdi-account"></i>
                            <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre" class="form-control" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="validarNombre" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="ExpresionNombre" runat="server" ErrorMessage="Solo se permiten letras" ControlToValidate="txtNombre" Display="Dynamic" ValidationExpression="^[a-zA-Z][a-zA-Z0-9]*$"></asp:RegularExpressionValidator>
                        </div>
                        <div class="form-holder col">
                            <i class="zmdi zmdi-account"></i>
                           <asp:TextBox ID="txtApellido1" runat="server" placeholder="Primer Apellido" class="form-control" ></asp:TextBox>
                             <asp:RequiredFieldValidator ID="ValidarApellido1" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtApellido1"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="ExpresionApellido1" runat="server" ErrorMessage="Solo se permiten letras" Display="Dynamic" ControlToValidate="txtApellido1" ValidationExpression="^[a-zA-Z][a-zA-Z0-9]*$"></asp:RegularExpressionValidator>
                       
                        </div>
                	</div>
                    <div class="form-group row">
                        <div class="form-holder col">
                            <i class="zmdi zmdi-account"></i>
                            <asp:TextBox ID="txtApellido2" runat="server" placeholder="Segundo Apellido" class="form-control" ></asp:TextBox>
                             <asp:RequiredFieldValidator ID="validarApellido2" runat="server"  ErrorMessage="*" Display="Dynamic" ControlToValidate="txtApellido2"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="ExpresionApellido2" runat="server"  ErrorMessage="Solo se permiten letras" Display="Dynamic" ControlToValidate="txtApellido2" ValidationExpression="^[a-zA-Z][a-zA-Z0-9]*$"></asp:RegularExpressionValidator>
                       
                        </div>
                        <div class="form-holder col">
                            <i class="zmdi zmdi-account-box-o"></i>
                           <asp:TextBox ID="txtIdentificacion" runat="server" placeholder="Identificación" class="form-control" ></asp:TextBox>
                             <asp:RequiredFieldValidator ID="validarIdentificacion" runat="server"  ErrorMessage="*" Display="Dynamic" ControlToValidate="txtIdentificacion"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="expresesionIdentificacon" runat="server" ErrorMessage="Solo se permiten numeros " Display="Dynamic" ControlToValidate="txtIdentificacion" ValidationExpression="^([0-9])*$"></asp:RegularExpressionValidator>
                       
                        </div>
                    </div>
                    <div class="form-group row">
                        <div class="form-holder col">
                            <i class="zmdi zmdi-email"></i>
                           <asp:TextBox ID="txtEmail" runat="server" placeholder="Correo Electronico" class="form-control" TextMode="Email"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="validarEmail" runat="server"  ErrorMessage="*" Display="Dynamic" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
                       
                        </div>
                            <div class="form-holder col">
                                <i class="zmdi zmdi-phone"></i>
                                <asp:TextBox ID="txtTelefono" runat="server" placeholder="Télefono" class="form-control" ></asp:TextBox>
                                <asp:RequiredFieldValidator ID="validarTelefono" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtTelefono"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="expresionTelefono" runat="server" ErrorMessage="Solo se permiten numeros " Display="Dynamic" ControlToValidate="txtTelefono" ValidationExpression="^([0-9])*$"></asp:RegularExpressionValidator>
                       
                            </div>
                    </div>
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server" >
                        <ContentTemplate>
                            
                             <div class="form-group row">
                        <div class="form-holder col">
                            <i class="zmdi zmdi-city"></i>
                            <asp:DropDownList ID="dllProvincia" runat="server" class="form-control" placeholder="Provincia" OnSelectedIndexChanged="dllProvincia_SelectedIndexChanged" AutoPostBack="True">
                                <asp:ListItem>----Provincia</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                          <div class="form-holder col">
                            <i class="zmdi zmdi-city"></i>
                           <asp:DropDownList ID="dllCanton" runat="server" class="form-control" OnSelectedIndexChanged="dllCanton_SelectedIndexChanged" AutoPostBack="true">
                               <asp:ListItem>----Canton</asp:ListItem>
                           </asp:DropDownList>

                        </div>
                    </div>
                    <div class="form-group row">
                        <div class="form-holder col">
                            <i class="zmdi zmdi-city"></i>
                            <asp:DropDownList ID="dllDistrito" runat="server" class="form-control" placeholder="Provincia">
                                <asp:ListItem>----Distrito</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>

                </section>

				<!-- SECTION 2 -->
                <h4></h4>
                <section>
                	<h3>Indicar cual es su rol</h3>
                   <ul class="nav nav-pills ">
                      <li class="nav-item">
                          <div class="col">
                              <asp:LinkButton ID="transportista" runat="server" class="nav" data-toggle="pill" href="#transportita"  CausesValidation="False" OnClientClick="return rolTransportista();">
                                  <img src="../../images/step-4-active.png"  /> <br />
                                 Transportista
                                  <script>
                                      function rolTransportista() {
                                          RolUser.value = "transportista";
                                          return RolUser.value;
                                      }
                                  </script>
                              </asp:LinkButton>
                          </div>
                      </li>
                      <li class="nav-item">
                          <div class="col">
                                <asp:LinkButton ID="cliente1" runat="server" class="nav" data-toggle="pill" href="#cliente"  CausesValidation="False" OnClientClick="return rolCliente();">
                                  <img src="../../images/step-3-active.png"  /> <br />
                                 Cliente
                                  <script>
                                      function rolCliente() {
                                          RolUser.value = "cliente";
                                          return RolUser.value;
                                      }
                                  </script>
                                </asp:LinkButton>
                          </div>
                      </li>
                      <li class="nav-item">
                          <div class="col">
                             <asp:LinkButton ID="vendedor2" runat="server" class="nav" data-toggle="pill" href="#vendedor"  CausesValidation="False" OnClientClick="return rolVendedor();">
                                  <img src="../../images/step-1-active.png"  /> <br />
                                 Vendedor
                                  <script>
                                      function rolVendedor() {
                                          RolUser.value = "vendedor";
                                          return RolUser.value;
                                      }
                                  </script>
                             </asp:LinkButton>
                          </div>
                      </li>
                    </ul>

                </section>

                <!-- SECTION 3 -->
                <h4></h4>
                <section>
                        <div class="tab-content">
                          <!--TRANSPORTISTA-->
                            <div class="tab-pane container active" id="transportita">
                                 <h4>Transportista</h4>
                                 <div class="form-group row">
                                        <div class="form-holder col">
                                            <i class="zmdi zmdi-car"></i>
                                           <asp:TextBox ID="txtLicencia" runat="server" placeholder="Tipo de licencia" class="form-control" ></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="validarLicencia" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtLicencia"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="expresionLicencia" runat="server" ErrorMessage="Solo se permiten numero o letras " Display="Dynamic" ControlToValidate="txtLicencia" ValidationExpression="^[a-zA-Z][a-zA-Z0-9]*$"></asp:RegularExpressionValidator>
                       
                                        </div>
                                        <div class="form-holder  col">
                                            <i class="zmdi zmdi-assignment-o"></i>
                                           <asp:TextBox ID="txtPlaca" runat="server" placeholder="Placa"  class="form-control" ></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="validarPlaca" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtPlaca"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="expresionPlaca" runat="server" ErrorMessage="Solo se permiten numero o letras " Display="Dynamic" ControlToValidate="txtPlaca" ValidationExpression="^([0-9])*$"></asp:RegularExpressionValidator>
                       
                                        </div>
                               </div>
                                <div class="form-group row">
                                        <div class="form-holder col">
                                            <i class="zmdi zmdi-car"></i>
                                            <asp:DropDownList ID="dllTipoVehiculo" runat="server" class="form-control" >
                                                <asp:ListItem>----Tipo Vehiculo</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="form-holder  col">
                                            <i class="zmdi zmdi-car"></i>
                                           <asp:TextBox ID="txtModelo" runat="server" placeholder="Modelo"  class="form-control" ></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="validarModelo" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtModelo"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="expresionModelo" runat="server" ErrorMessage="Solo se permiten numero o letras " Display="Dynamic" ControlToValidate="txtModelo" ValidationExpression="^[a-zA-Z][a-zA-Z0-9]*$"></asp:RegularExpressionValidator>
                       
                                        </div>
                               </div>
                                <div class="form-group row">
                                      <div class="form-holder  col">
                                             <i class="zmdi zmdi-colorize"></i>
                                           <asp:TextBox ID="txtColor" runat="server" placeholder="Color"  class="form-control" ></asp:TextBox>
                                           <asp:RequiredFieldValidator ID="validarColor" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtColor"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="expresionColor" runat="server" ErrorMessage="Solo se permiten letras " Display="Dynamic" ControlToValidate="txtColor" ValidationExpression="^[a-zA-Z][a-zA-Z0-9]*$"></asp:RegularExpressionValidator>
                                        </div>
                                     <div class="form-holder  col">
                                            <i class="zmdi zmdi-lock-open"></i>
                                           <asp:TextBox ID="txtMarca" runat="server" placeholder="Marca"  class="form-control" ></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="validarMarca" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtMarca"></asp:RequiredFieldValidator>
                                             <asp:RegularExpressionValidator ID="expresionMarca" runat="server" ErrorMessage="Solo se permiten letras " Display="Dynamic" ControlToValidate="txtMarca" ValidationExpression="^[a-zA-Z][a-zA-Z0-9]*$"></asp:RegularExpressionValidator>
                                        </div>

                                </div>
                              
                              <div class="form-group row">
                                        <div class="form-holder col">
                                            <i class="zmdi zmdi-account"></i>
                                           <asp:TextBox ID="txtUsuarioTransportista" runat="server" placeholder="Usuario" class="form-control" ></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="validarUsuarioTransportista" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtUsuarioTransportista"></asp:RequiredFieldValidator>
                                        </div>
                                        <div class="form-holder  col">
                                            <i class="zmdi zmdi-lock-open"></i>
                                           <asp:TextBox ID="txtContraseñaTrasnportista" runat="server" placeholder="Contraseña" TextMode="Password" class="form-control" ></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="ValidarContraseñaTransportista" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtContraseñaTrasnportista"></asp:RequiredFieldValidator>
                                        </div>
                               </div>


                          </div>

                            <!--CLIENTE-->
                          <div class="tab-pane container fade" id="cliente">
                              <h4>Cliente</h4>
                               <div class="form-group row">
                                        <div class="form-holder col">
                                            <i class="zmdi zmdi-account"></i>
                                           <asp:TextBox ID="txtUsuarioCliente" runat="server" placeholder="Usuario" class="form-control" ></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="validarUsuarioCliente" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtUsuarioCliente"></asp:RequiredFieldValidator>
                                        </div>
                                        <div class="form-holder  col">
                                            <i class="zmdi zmdi-lock-open"></i>
                                           <asp:TextBox ID="txtContraseñaCliente" runat="server" placeholder="Contraseña" TextMode="Password" class="form-control" ></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="ValidarContraseñaCliente" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtContraseñaCliente"></asp:RequiredFieldValidator>
                                        </div>
                               </div>
                          </div>
                            <!--VENDEDOR-->
                          <div class="tab-pane container fade" id="vendedor">
                              <h4>Vendedor</h4>
                              <div class="form-group row">
                                        <div class="form-holder col">
                                            <i class="zmdi zmdi-account"></i>
                                           <asp:TextBox ID="txtVendedorUsuario" runat="server" placeholder="Usuario" class="form-control" ></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="validarUsuarioVendedor" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtVendedorUsuario"></asp:RequiredFieldValidator>
                                   
                                        </div>
                                        <div class="form-holder  col">
                                            <i class="zmdi zmdi-lock-open"></i>
                                           <asp:TextBox ID="txtVendedorContraseña" runat="server" placeholder="Contraseña" TextMode="Password" class="form-control" ></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="ValidarContraseñaVendedor" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtVendedorContraseña"></asp:RequiredFieldValidator>
                                      
                                        </div>
                               </div>
                              <div class="form-group row">
                                  <div class="form-holder col">
                                      <i class="zmdi zmdi-card"></i>
                                      <asp:DropDownList ID="dllTipoPago" runat="server"  class="form-control" >
                                           <asp:ListItem>----Tipo pago</asp:ListItem>
                                      </asp:DropDownList>

                                  </div>
                              </div>
                          </div>
                        </div>
                   
                </section>

                <!-- SECTION 4 -->
                <h4></h4>
                <section>
                            <asp:Panel ID="pnlMensaje" runat="server" Visible="false">
                                <div class="alert alert-danger" role="alert">
                                    <strong>Atención!</strong> Se ha presentado el siguiente problema.
                            <br />
                                    <br />
                                    <asp:BulletedList ID="blMensajes" runat="server"></asp:BulletedList>
                                </div>
                            </asp:Panel>
                            <h3>Envio</h3>
                            <h5>Advertencia:
                        Revice los datos que ha ingresado, ya que al precionar el boton se enviaran los datos y no se podra modificar.
                            </h5>
                            <div class="text-center">
                                <asp:Button ID="btnRegistro" runat="server" Text="Enviar" CssClass="btn btn-success" OnClick="btnRegistro_Click" CausesValidation="False" />
                            </div>
                </section>
               
            </form>
		</div>
        
		<script src="../../js/jquery-3.3.1.min.js"></script>
		<script src="../../js/jquery.steps.js"></script>
		<script src="../../js/main.js"></script>

</body>
</html>