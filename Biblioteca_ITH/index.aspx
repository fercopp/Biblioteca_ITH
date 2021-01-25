<%@ Page Title="" Language="C#" MasterPageFile="~/Front.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Biblioteca_ITH.index2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">

    <!--Recorrido Virtual Video-->
    <div class="py-3 mb-5" style="background-color:lightgray">
        <h1 class="text-uppercase faded text-dark text-center pt-2 pb-4"><strong>Recorrido Virtual</strong></h1>
        <div id="video" class="container">
            <div class="row">
                <div class="embed-responsive embed-responsive-16by9 col-12">
                  <iframe class="embed-responsive-item" src="https://www.youtube.com/embed/jGtGu2ycuWU"></iframe>
                </div>
            </div>       
        </div>
    </div>


    <h1 class="text-uppercase faded text-dark text-center pb-2 my-3"><strong>Galeria de Fotos</strong></h1>
    <!--Carousel Wrapper-->
    <div id="multi-item-example" class="carousel slide carousel-multi-item carousel-multi-item-2 m-2" data-ride="carousel" style="text-align:center;">

      <!--Controls-->
      <div class="controls-top">
        <a class="black-text" href="#multi-item-example" data-slide="prev"><i class="fas fa-angle-left fa-3x pr-3" style="color: #FF7F00" ></i></a>
        <a class="black-text" href="#multi-item-example" data-slide="next"><i class="fas fa-angle-right fa-3x pl-3" style="color: #FF7F00"></i></a>
      </div>
      <!--/.Controls-->

      <!--Slides-->
      <div class="carousel-inner mb-5" role="listbox">

        <!--First slide-->
        
        <div class="carousel-item active">
            <div class="row">
            <asp:ListView ID="lstNewGaleria1" runat="server">
             <ItemTemplate>
                <div class="col-md-3 mb-3">
                    <div class="card">
                        <asp:Image ID="imgGaleria1" runat="server" CssClass="card-img-top" ImageUrl='<%# "~/include/images/Instalaciones/" + Eval("imagen") %>' />
                    </div>
                </div>
              </ItemTemplate>
		     
                <ItemTemplate>
                  <div class="col-md-3 mb-3">
                    <div class="card">
                      <asp:Image ID="imgGaleria2" runat="server" CssClass="card-img-top" ImageUrl='<%# "~/include/images/Instalaciones/" + Eval("imagen") %>' />
                    </div>
                  </div>
                </ItemTemplate>
                <ItemTemplate>
                  <div class="col-md-3 mb-3">
                    <div class="card">
                      <asp:Image ID="imgGaleria3" runat="server" CssClass="card-img-top" ImageUrl='<%# "~/include/images/Instalaciones/" + Eval("imagen") %>' />
                    </div>
                  </div>
                </ItemTemplate>

                <ItemTemplate>
                  <div class="col-md-3 mb-3">
                    <div class="card">
                      <asp:Image ID="imgGaleria4" runat="server" CssClass="card-img-top" ImageUrl='<%# "~/include/images/Instalaciones/" + Eval("imagen") %>' />
                    </div>
                  </div>
                </ItemTemplate>
                </asp:ListView>
            </div>
        </div>
        <!--/.First slide-->

        <!--Second slide-->
        <div class="carousel-item">
         <div class="row">
          <div class="col-md-3 mb-3">
            <div class="card">
              <img class="img-fluid" src="include/images/Instalaciones/WhatsApp%20Image%202020-11-05%20at%2010.39.41%20AM.jpeg"
                alt="Card image cap">
            </div>
          </div>

          <div class="col-md-3 mb-3">
            <div class="card">
              <img class="img-fluid" src="include/images/Instalaciones/20201104_130539.jpg"
                alt="Card image cap">
            </div>
          </div>
          <div class="col-md-3 mb-3">
            <div class="card">
              <img class="img-fluid" src="include/images/Instalaciones/biblio.jpg"
                alt="Card image cap">
            </div>
          </div>

          <div class="col-md-3 mb-3">
            <div class="card">
              <img class="img-fluid" src="include/images/Instalaciones/biblio2.jpg"
                alt="Card image cap">
            </div>
          </div>
         </div>
        </div>
        <!--/.Second slide-->

      </div>
      <!--/.Slides-->

    </div>
    <!--/.Carousel Wrapper-->


</asp:Content>


