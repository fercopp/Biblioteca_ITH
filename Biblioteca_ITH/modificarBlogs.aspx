<%@ Page Title="" Language="C#" MasterPageFile="~/Back.Master" AutoEventWireup="true" CodeBehind="modificarBlogs.aspx.cs" Inherits="Biblioteca_ITH.agregarBlogs" EnableEventValidation="false" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content mt-3">
        <div class="animated fadeIn">
            <div class="row">
                <div class="col-md-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Blogs</strong>
                        </div>
                        <div class="card-body">
                            <div class="col-md-6 text-right mb-3">
                                <h4 class="h3 mb-0 text-gray-800">Agregar un nuevo Blog <asp:Button runat="server" CssClass="btn btn-success" Text="Agregar" ID="btnAgregar" CausesValidation="false" OnClick="Btn_Agregar_Click"/></h4>
                                   
                            </div>
                            <table id="bootstrap-data-table-export" class="table table-striped table-bordered">
                                <thead>
                                    <tr>
                                        <th>Imagen</th>
                                        <th>Titulo</th>
                                        <th>Descripcion</th>
                                    </tr>
                                </thead>
                                <tbody>
                                        
                                    <asp:ListView ID="lstBlogs" runat="server">
                                        <ItemTemplate>
                                            <tr>
                                                <td><asp:Image ID="imgBlog" CssClass="img-fluid" Height="250" Width="300" runat="server" ImageUrl='<%# "~/include/images/Blogs/" + Eval("imagen") %>'></asp:Image></td>
                                                <td><asp:Literal ID="litTitulo" Text='<%#Eval("titulo") %>' runat="server"></asp:Literal></td>
                                                <td><asp:Literal ID="litDescripcion" Text='<%#Eval("descripcion") %>' runat="server"></asp:Literal></td>
                                                <td><i class="fa fa-<asp:Literal ID="litActive" Text='<%#(bool)Eval("activo") ? "check" : "times"%>' runat="server"></asp:Literal>"></i></td>

                                                <td>
                                                    <asp:Button ID="btnEditar" obj='<%#Eval("id") %>' OnClick="Btn_Editar_Click"  CssClass="btn btn-warning" runat="server" Text="Editar" />
                                                    <asp:Button ID="btnBorrar" obj='<%#Eval("id") %>' OnClick="Btn_Borrar_Click"  CssClass="btn btn-danger" runat="server" Text="Borrar" />
                                                </td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:ListView>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div><!-- .content -->


    <div class="modal fade" id="modal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="lblModal" runat="server">Agregar</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="form-horizontal">
                            <asp:HiddenField ID="hdnProdId" runat="server" Value="0"/>
                            <div class="row form-group">
                                <div class="col col-md-3"><label class=" form-control-label">Titulo</label></div>
                                <div class="col-12 col-md-9"><asp:TextBox ID="txtTitulo" CssClass="form-control" runat="server"></asp:TextBox></div>
                            </div>
                            <div class="row form-group">
                                <div class="col col-md-3"><label  class=" form-control-label">Descripcion</label></div>
                                <div class="col-12 col-md-9"><asp:TextBox ID="txtDesc" CssClass="form-control" runat="server" TextMode="MultiLine"></asp:TextBox></div>
                            </div>                           
                            <div class="row form-group">
                                <div class="col col-md-3"><label  class=" form-control-label">Imagen</label></div>
                                <div class="col-12 col-md-9"><asp:FileUpload ID="fupImagen" runat="server" /></div>
                                <asp:Label CssClass="col-md-9 offset-md-3" runat="server" ID="lblImagen"></asp:Label>
                            </div>
                            <div class="row form-group">
                                <div class="col col-md-3"><label class=" form-control-label">Activo</label></div>
                                <div class="col-12 col-md-9"><asp:Checkbox ID="chkActivo" runat="server"></asp:Checkbox></div>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <asp:LinkButton ID="LinkButton1" OnClick="Lbt_Guardar_Click" CssClass="btn btn-primary" runat="server">
                        <i class="fa fa-dot-circle-o"></i> Guardar
                        </asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>



</asp:Content>

