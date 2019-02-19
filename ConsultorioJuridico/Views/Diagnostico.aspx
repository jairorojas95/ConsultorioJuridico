<%@ Page Title="" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="Diagnostico.aspx.cs" Inherits="juefi2.Views.Diagnostico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Diagnostico</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-10">
        <div class="box box-primary" style="background: #E0E6F8">
            <div class="box-header with-border">
                <center><h3 class="box-title">Diagnostico</h3></center>
            </div>
            <div class="box-body">
                <div class="col-md-6  ">
                    <div class="form-group">
                        <label>Radicado</label>
                        <asp:DropDownList ID="DropRadicado" CssClass="form-control select2 text-center" AppendDataBoundItems="true" runat="server">
                            <asp:ListItem Value="" Text="      ---- Seleccion ----     "> </asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
               
               
                
                <div class="col-md-6 ">
                    <div class="form-group">
                        <label for="exampleInputFile">Cargar Diagnostico</label>
                        <asp:FileUpload ID="MyFile" runat="server" />
                    </div>
                </div>



            </div>
        </div>
        <div class="box box-primary">
            <div class="box-header with-border" style="background: #E0E6F8">
                <center>  
                    <asp:Button ID="Guardar_diagnostico" style="background:#2E9AFE" Text="Crear Diagnostico"  runat="server" OnClick="Guardar_diagnostico_Click"
                        />
                   
                </center>
            </div>
        </div>
    </div>



</asp:Content>
