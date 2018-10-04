<%@ Page Title="" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="Diagnostico.aspx.cs" Inherits="juefi2.Views.Diagnostico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
         <title>Diagnostico</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-8">
          <div class="box box-primary" style="background:#E0E6F8">
            <div class="box-header with-border">
                <center><h3 class="box-title">Diagnostico</h3></center>
            </div>
            <div class="box-body">
                <div class="col-md-6 ">
                    <div class="form-group">
                        <label>ID Proceso </label>
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
                        <label>Clase Proceso </label>
                        <asp:TextBox ID="Textaccionante" runat="server" CssClass=" form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-6 ">
                    <div class="form-group">

                        <label>Estudiante</label>
                        <asp:TextBox ID="Textentidad" runat="server" CssClass=" form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label>Fecha Diagnostico</label>
                        <div class="input-group">
                            <div class="input-group-addon">
                                <i class="fa fa-calendar"></i>
                            </div>
                            <input type="date" class="form-control" id="datepicker" />
                        </div>
                    </div>
                </div>
                <div class="col-md-6 ">
                    <div class="form-group">
                        <label>Accionante</label>
                        <asp:TextBox ID="Textclaseproceso" runat="server" CssClass=" form-control"></asp:TextBox>
                    </div>
                </div>
              <div class="col-md-6 ">
                <div class="form-group">
                    <label for="exampleInputFile">Cargar Diagnostico</label>
                    <input type="file" id="exampleInputFile">
                </div>
            </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label>Accionado</label>
                        <asp:TextBox ID="Textradicado" runat="server" CssClass=" form-control"></asp:TextBox>
                    </div>
                </div>     
                
                  
            </div>
        </div>
         <div class="box box-primary">
            <div class="box-header with-border" style="background:#E0E6F8">
                <center>  
                    <asp:Button ID="Button1" style="background:#2E9AFE" Text="Crear Diagnostico"  runat="server"/>
                   
                </center>
            </div>
              </div>     
    </div>



</asp:Content>
