<%@ Page Title="" Language="C#" MasterPageFile="~/Front.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="Biblioteca_ITH.signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">

	<section class="login_box_area section_gap" style="margin-bottom:10%">
		<div class="container">
			<div class="row">
				<div class="col-lg-12">
					<div class="login_form_inner pt-4">
						<h3>Crear cuenta</h3>
						<div class="row login_form">
							<div class="col-md-12 form-group">
								<asp:TextBox runat="server" class="form-control" ID="txtNombre"  placeholder="Nombre" />
							</div>
							<div class="col-md-6 form-group">
								<asp:TextBox runat="server" class="form-control" ID="txtPrimerApellido" placeholder="Primer Apellido" />
							</div>
							<div class="col-md-6 form-group">
								<asp:TextBox runat="server" class="form-control" ID="txtSegundoApellido" placeholder="Segundo Apellido" />
							</div>
							<div class="col-md-12 form-group">
								<asp:TextBox runat="server" class="form-control" ID="txtEmail" placeholder="Correo Electrónico" />
							</div>
							<div class="col-md-12 form-group">
								<asp:TextBox runat="server" class="form-control" ID="txtTelefono" placeholder="Telefono" />
							</div>
							<div class="col-md-12 form-group">
								<asp:TextBox runat="server" class="form-control" ID="txtContraseña" placeholder="Contraseña" TextMode="Password" />
							</div>
							<div class="col-md-12 form-group">
								<asp:TextBox runat="server" class="form-control" ID="txtContraseñaConfirmar" placeholder="Confirmar Contraseña" TextMode="Password" />
							</div>
							<div class="col-md-12 form-group">
								<div class="create_account">
								</div>
							</div>
							<div class="col-md-12 form-group">
								<asp:Button runat="server" Text="Crear Cuenta" ID="btnCrear" class="primary-btn" OnClick="Btn_Crear_Click" />
							</div>
							<div class="hover col-md-12 form-group">
								<h4>¿Ya tienes cuanta?</h4>
							<a class="primary-btn" href="login.aspx">Iniciar Sesion</a>
						</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</section>
</asp:Content>
