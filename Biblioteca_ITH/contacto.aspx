<%@ Page Title="" Language="C#" MasterPageFile="~/Front.Master" AutoEventWireup="true" CodeBehind="contacto.aspx.cs" Inherits="Biblioteca_ITH.contacto1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">

    <section class="login_box_area section_gap">
		<div class="container">
			<div class="row">
				<div class="col-lg-12">
					<div class=" pt-4 ">
						<div class="row">
							<div class="text-center formulario login_form col-lg-12 px-5">
								<h2 class="mb-5">Contactanos</h2>
								<div class="form-row">
									<div class="form-group col-md-12">
										<asp:TextBox ID="txtNombre" class="form-control" runat="server" placeholder="Nombre"/>  
									</div>
								</div>
								<div class="form-row">
									<div class="form-group col-md-12">
										<asp:TextBox ID="txtApellido1" class="form-control" runat="server" placeholder="Primer Apellido"/>  
									</div>
								</div>
								<div class="form-row">
									<div class="form-group col-md-12">
										<asp:TextBox ID="txtApellido2" class="form-control" runat="server" placeholder="Segundo Apelldo" />  
									</div>
								</div>
								<div class="form-row">
									<div class="form-group col-md-12">
										<asp:TextBox class="form-control" ID="txtCorreo" placeholder="Correo Electrónico" runat="server" />
									</div>
								</div>
								<div class="form-group">
									<label for="txtSugerencia">Mensaje o Sugerencia</label>
									<asp:TextBox class="form-control" ID="txtSugerencia" placeholder="Tu mensaje aqui..." runat="server" TextMode="MultiLine"/>
								</div>
								<asp:Button runat="server" Text="Enviar" ID="btnEnviar" class="btn btn-warning" style="margin-bottom:450px;" onClick="Btn_Enviar_Click"/>

							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</section>

</asp:Content>
