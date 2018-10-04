<%@ Page Title="" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="CrearProceso.aspx.cs" Inherits="juefi2.Views.CrearProceso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <title>Hoja de Cierre</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-8">
          <div class="box box-primary" style="background:#E0E6F8">
            <div class="box-header with-border">
                <center><h3 class="box-title">Hoja de Cierre</h3></center>
            </div>
            <div class="box-body">
                <div class="col-md-6 ">
                    <div class="form-group">
                        <label>Nombre Proceso </label>
                       <asp:DropDownList ID="DropIntegrantes" CssClass="form-control select2" runat="server">
                        <asp:ListItem Value="none">-------</asp:ListItem>
                        <asp:ListItem Value="Contitucional">Contitucional</asp:ListItem>
                        <asp:ListItem Value="Administrativo">Administrativo</asp:ListItem>
                           </asp:DropDownList>
                    </div>
                     </div>
                <div class="col-md-6 ">
                    <div class="form-group">
                        <label>Descripcion Cierre </label>
                        <asp:TextBox ID="Textasesor" runat="server" CssClass=" form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label>Fecha Cierre</label>
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
                        <br />
                <center> <asp:Button ID="Button3" style="background:#2E9AFE"  CssClass="btn btn-outline-primary" runat="server" Text="Cierre Proceso"></asp:Button>
                    </div>
                </div> 
                </div>
              </div>
       
          <div class="box box-primary">
            <div class="box-header with-border" style="background:#E0E6F8">
                <center> <asp:Button ID="Button5" style="background:#2E9AFE" CssClass="btn btn-outline-primary" runat="server" Text="Aprovación Director"></asp:Button>
                        <asp:Button ID="Button2" style="background:#2E9AFE" CssClass="btn btn-outline-primary" runat="server" Text="Aprovación Administrador"></asp:Button>
                          <asp:Button ID="Button1" style="background:#2E9AFE" CssClass="btn btn-outline-primary" runat="server" Text="Aprovación Asesor"></asp:Button>
                </center>
            </div>
              </div>
                  </div>
</asp:Content>
