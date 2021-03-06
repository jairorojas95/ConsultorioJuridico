﻿<%@ Page Title="Nuevo Tipo de Documento" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="TipodeDocumento.aspx.cs" Inherits="juefi2.Views.TipodeDocumento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-8 ">
        <div class="box box-primary">
            <div class="toolbar__nav">
                <a href="/Views/principal.aspx">
                    <h5><i class="fa fa-home">&nbsp;</i>Inicio <span>>> </span><a href='#'><i class="fa  fa-credit-card">&nbsp;</i>Nuevo Tipo de Documento</h5>
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
                <b class="box-title">Nuevo Tipo de Documento</b></>
            </div>
            <div class="box-body">

                <div class="col-md-6  ">
                    <div class="form-group">

                        <label>Documento</label><br />
                        <asp:DropDownList ID="Dropdocument" CssClass="form-control select2 text-center"  AppendDataBoundItems="true"  runat="server" AutoPostBack="true" >
                            <asp:ListItem Value=""> ------- seleccioné ------ </asp:ListItem>

                        </asp:DropDownList>
                    </div>
                </div>



                <div class="col-md-6 ">
                    <div class="form-group">
                        <label>Nombre del Nuevo Documento</label>
                        <asp:TextBox ID="Txnuevodocumen" runat="server" CssClass=" form-control" required></asp:TextBox>
                    </div>
                </div>


                <div class="col-md-6 ">
                    <div class="form-group">
                        <br />
                        <center> <asp:Button ID="guardar"  CssClass="btn btn-primary" runat="server" Text="Crear Tipo Proceso" OnClick="guardar_Click" ></asp:Button>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
