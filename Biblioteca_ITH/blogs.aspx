<%@ Page Title="" Language="C#" MasterPageFile="~/Front.Master" AutoEventWireup="true" CodeBehind="blogs.aspx.cs" Inherits="Biblioteca_ITH.blogs1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">

    <div class="container">
        <div class="row">

          <!-- Blog Entries Column -->
          <div class="col-8">
           <div class="col-12">
                <h1 class="my-4">Blog
                  <small>Biblioteca ITH</small>
                </h1>
           </div>
            <!-- Blog Post -->
          <asp:ListView ID="lstNewBlog" runat="server">
             <ItemTemplate>
             <div class="col-md-12">
                <div class="card mb-4 blogFoto">
                    <asp:Image ID="imgBlog" runat="server" CssClass="card-img-top" ImageUrl='<%# "~/include/images/Blogs/" + Eval("imagen") %>' />
                  <div class="card-body">
                    <h2><asp:Label ID="lblTitulo" CssClass="card-title" runat="server" Text='<%#Eval("titulo") %>' /></h2>
                    <p><asp:Label ID="lblDescripcion" CssClass="card-text" runat="server" Text='<%#Eval("descripcion") %>'/></p>
                    <a href="#" class="btn btn-primary">Leer Mas &rarr;</a>
                  </div>
                  <div class="card-footer text-muted">
                    Publicado el 05 de Noviembre, 2020
                  </div>
                </div>
                </div>
               </ItemTemplate>
		  </asp:ListView>

         </div>

          <!-- Sidebar Widgets Column -->
          <div class="col-md-4">

            <!-- Side Widget -->
            <div class="card my-4">
              <h5 class="card-header">Información Extra</h5>
              <div class="card-body">
                Si quieres publicar un blog mandanos un mensaje  en la sección de contactanos y nosotros lo publicamos.
              </div>
            </div>

          </div>   
        </div>
        <!-- /.row -->
      </div>
    <!-- /.container -->
    

</asp:Content>
