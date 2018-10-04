<%@ Page Title="" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="CrearProceso.aspx.cs" Inherits="juefi2.Views.CrearProceso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     
    <div class="col-md-6">
          <div class="box box-primary" style="background:#E0E6F8">
            <div class="box-header with-border">
                <center><h3 class="box-title">Entidad</h3></center>
            </div>
            <div class="box-body">
                <div class="col-md-6 ">
                    <div class="form-group">
                        <label>Nombre Entidad</label>
                        <asp:TextBox ID="Txtarea" runat="server" CssClass=" form-control"></asp:TextBox>
                    </div>
                     </div>
                  <div class="col-md-6 ">
                    <div class="form-group">
                        <br />
                <center> <asp:Button ID="Button3" style="background:#2E9AFE"  CssClass="btn btn-outline-primary" runat="server" Text="Crear Entidad"></asp:Button>
                    </div>
                </div> 
                </div>
             
              </div>
         </div>
</asp:Content>
