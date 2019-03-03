<%@ Page Title="" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="juefi2.Views.probador.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <div class="col-md-8 ">
        <div class="box box-primary">
            <div class="toolbar__nav">
                <a href="/Views/principal.aspx">
                    <h5><i class="fa fa-home">&nbsp;</i>Inicio <span>>> </span><a href='#'><i class="fa fa-delicious">&nbsp;</i>Reporte</h5>
                    <br />
                </a>
            </div>
        </div>
    </div>
    <br />
    <br />

    <div class="col-md-8 ">
        <div class="box box-primary">

            <div class="box-header with-border text-center">
                <b class="box-title">Reporte</b></>
            </div>
            <div class="box-body">

                <div class="col-md-6  ">
                    <div class="form-group">

                        <asp:Button ID="Button1" CssClass="btn btn-primary" OnClick="reporte1_Click" runat="server" Text="Ver Reporte"></asp:Button>
                    </div>
                </div>
                                
            </div>
        </div>
    </div>

</asp:Content>
