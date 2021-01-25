<%@ Page Title="" Language="C#" MasterPageFile="~/Front.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Biblioteca_ITH.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">


	<section class="login_box_area section_gap" style="margin-bottom:13%">
		<div class="container">
			<div class="row">
				<div class="col-lg-12">
					<div class="login_form_inner">
						<h3>Log in</h3>
						<div class="row login_form">
							<div class="col-md-12 form-group">
								<asp:TextBox runat="server" class="form-control" ID="txtEmail" placeholder="Correo Electrónico" />
								<asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage=" *Campo requerido" ForeColor="Navy" Display="Dynamic" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
								<asp:RegularExpressionValidator ID="revEmail" runat="server" ErrorMessage=" *Formato incorrecto" ForeColor="Navy" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"></asp:RegularExpressionValidator>
							</div>
							<div class="col-md-12 form-group">
								<asp:TextBox runat="server" class="form-control" ID="txtContraseña" placeholder="Contraseña" TextMode="Password" />
								<asp:RequiredFieldValidator ID="rfvContraseña" runat="server" ErrorMessage=" *Campo requerido" ForeColor="Navy" Display="Dynamic" ControlToValidate="txtContraseña"></asp:RequiredFieldValidator>
							</div>
							<div class="col-md-12 form-group">
								<div class="creat_account">
									<asp:CheckBox runat="server" ID="chkMantenerLog"  Text="Mantener Sesión"/>
								</div>
							</div>
							<div class="col-md-12 form-group">								
								<asp:Button runat="server" Text="Iniciar Sesión" ID="btnInicio" class="primary-btn" OnClick="btnInicio_Click"  />
								<a href="#">¿Olvidaste tu contraseña? </a>
							</div>
							<div class="hover col-md-12 form-group">
								<h4>¿No tienes cuenta?</h4>
							<a class="primary-btn" href="signup.aspx">Crear cuenta</a>
						</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</section>

</asp:Content>
