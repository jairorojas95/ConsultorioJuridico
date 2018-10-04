<%@ Page Title="" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="HojadeRuta.aspx.cs" Inherits="juefi2.Views.Vista1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <title>Hoja de Ruta</title>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

   
 <div class="col-md-8">
        <div class="box box-primary" style="background:#E0E6F8">
            <div class="box-header with-border">
                 <center><h3 class="box-title">Hoja de Ruta</h3> </center>
            </div>
            <div class="box-body">

                <div class="col-md-6 ">
                    <div class="form-group">
                        
                        <label>Area </label>
                        <asp:TextBox ID="Txtarea" runat="server" CssClass=" form-control"></asp:TextBox>

                    </div>
                    </div>
                <div class="col-md-6 ">
                    <div class="form-group">
                        
                        <label>Asesor </label>
                        <asp:TextBox ID="Textasesor" runat="server" CssClass=" form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-6 ">
                    <div class="form-group">                       
                        <label>Accionante </label>
                        <asp:TextBox ID="Textaccionante" runat="server" CssClass=" form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-6 ">
                    <div class="form-group">
                        
                        <label>Entidad </label>
                        <asp:TextBox ID="Textentidad" runat="server" CssClass=" form-control"></asp:TextBox>

                    </div>
                </div>
                <div class="col-md-6 ">
                    <div class="form-group">                        
                        <label>Accionado </label>
                        <asp:TextBox ID="Textaccionado" runat="server" CssClass=" form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-6 ">
                    <div class="form-group">                        
                        <label>Clase de Proceso</label>
                        <asp:TextBox ID="Textclaseproceso" runat="server" CssClass=" form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-6 ">
                    <div class="form-group">
                        
                        <label>Estudiante </label>
                        <asp:TextBox ID="Textestudiante" runat="server" CssClass=" form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">                       
                        <label>Radicado</label>
                        <asp:TextBox ID="Textradicado" runat="server" CssClass=" form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label>Fecha de Asignacion</label>
                        <div class="input-group">
                            <div class="input-group-addon">
                                <i class="fa fa-calendar"></i>
                            </div>
                            <input type="date" class="form-control" id="datepicker" />
                        </div>
                    </div>
                </div>              
            </div>
        </div>
             <div class="box box-primary">
            <div class="box-header with-border" style="background:#E0E6F8">
                <center>  
                    <asp:Button ID="Button1" style="background:#2E9AFE" Text="Guardar" OnClick="guardar" runat="server"/>
                    <asp:Button ID="Button2" style="background:#2E9AFE" Text="Consultar" OnClick="consulta" runat="server"/>
                </center>
            </div>
              </div>
    </div>

</asp:Content>



