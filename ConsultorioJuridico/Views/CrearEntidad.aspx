<%@ Page Title="Nuevo Tipo Proceso" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="CrearEntidad.aspx.cs" Inherits="juefi2.Views.CrearEntidad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <div class="col-md-8 ">
        <div class="box box-primary">
            <div class="toolbar__nav">
                <a href="/Views/principal.aspx">
                    <h5><i class="fa fa-home">&nbsp;</i>Inicio <span>>> </span><a href='#'><i class="fa fa-delicious">&nbsp;</i>Nuevo Tipo Proceso</h5>
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
                <b class="box-title">Nuevo Tipo Proceso</b></>
            </div>
            <div class="box-body">

                <div class="col-md-6  ">
                    <div class="form-group">

                        <label>Procesos</label><br />
                        <asp:DropDownList ID="Dropproceso" CssClass="form-control select2 text-center"   AppendDataBoundItems="true"  runat="server" AutoPostBack="true" >
                            <asp:ListItem Value=""> ------- seleccioné ------ </asp:ListItem>

                        </asp:DropDownList>
                    </div>
                </div>



                <div class="col-md-6 ">
                    <div class="form-group">
                        <label>Nombre del Nuevo Proceso</label>
                        <asp:TextBox ID="Txnuevoproceos" runat="server" CssClass=" form-control" required></asp:TextBox>
                    </div>
                </div>


                <div class="col-md-6 ">
                    <div class="form-group">
                        <br />
                        <center> <asp:Button ID="guardar"  CssClass="btn btn-primary" runat="server" Text="Crear Tipo Proceso" OnClick="guardar_Click"></asp:Button>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
