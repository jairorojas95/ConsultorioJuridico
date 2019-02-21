<%@ Page Title="" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="principal.aspx.cs" Inherits="juefi2.Views.usuario.principal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    
    <header class="content__title">
        <div class="toolbar">
            <div class="col-md-9 ">
                <div class="toolbar__nav">
                    <a href="/Views/principal.aspx">
                        <h5><i class="fa  fa-home ">&nbsp;</i>Inicio</h5>
                    </a>
                </div>
            </div>
        </div>
    </header>


        <div class="col-md-12 ">
                
        <div class="card">
            <div class="card-body">
                <h1><i class="fa fa-gavel"></i>Consultorio Juridico</h1>

                <div class="col-md-12 col-md-offset-2 ">
                    <div class="form-group">
                        <div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
                            <div class="carousel-inner" role="listbox">
                                <div class="carousel-item active">
                                    <img src="../../Content/imagenes/imagesinicio/consultorio.jpeg" alt="First slide" />
                                    <div class="carousel-caption">
                                    </div>
                                </div>
                            </div>
                        </div>
                       
                        <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
                            <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        </a>
                    </div>
                </div>
                <br />

                <div class="col-md-12  ">
                    <div class="form-group">

                        <p style="font-size: 17px; text-align: justify;">Este proyecto se visiona con el objetivo de optimizar el tratamiento de la información referente a cada una de las actividades que se llevan a cabo en el consultorio jurídico, pues actualmente en la mayoría este proceso se realiza de forma física y existe un riesgo enorme de pérdida de información.</p>
                    </div>
                </div>

            </div>



        </div>
    </div>
</asp:Content>
