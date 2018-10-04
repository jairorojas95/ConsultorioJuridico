<%@ Page Title="" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="CrearProceso.aspx.cs" Inherits="juefi2.Views.CrearProceso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <title>Crear Nuevo Proceso</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-8">

        <div class="box box-primary" style="background: #E0E6F8">
            <div class="box-header with-border">
                <center> <h3 class="box-title">Crear Nuevo Proceso</h3> </center>
            </div>



            <div class="box-body">

                <div class="col-md-6  ">
                    <div class="form-group">
                        <label>Tipo de Proceso</label>

                        <asp:DropDownList ID="DropDownList1" CssClass="form-control select2" runat="server">
                            <asp:ListItem Value="none">-------</asp:ListItem>
                            <asp:ListItem Value="Contitucional">Contitucional</asp:ListItem>
                            <asp:ListItem Value="Administrativo">Administrativo</asp:ListItem>
                            <asp:ListItem Value="Financiero">Financiero</asp:ListItem>
                            <asp:ListItem Value="Penal">Penal</asp:ListItem>
                            <asp:ListItem Value="Procesal">Procesal</asp:ListItem>
                            <asp:ListItem Value="Tributario">Tributario</asp:ListItem>
                            <asp:ListItem Value="Civil">Civil</asp:ListItem>
                            <asp:ListItem Value="Mercantil">Mercantil</asp:ListItem>
                            <asp:ListItem Value="Laboral">Laboral</asp:ListItem>
                            <asp:ListItem Value="Agrario">Agrario</asp:ListItem>
                            <asp:ListItem Value="Familia">Familia</asp:ListItem>

                        </asp:DropDownList>

                    </div>
                </div>


                <div class="col-md-6  ">
                    <div class="form-group">
                        <label>Asesor</label>

                        <asp:DropDownList ID="DropIntegrantes" CssClass="form-control select2" runat="server">
                            <asp:ListItem Value="none">-------</asp:ListItem>
                            <asp:ListItem Value="Contitucional">Juan Perez</asp:ListItem>
                            <asp:ListItem Value="Administrativo">Camilo Torres</asp:ListItem>
                            <asp:ListItem Value="Financiero">Daniel Paz</asp:ListItem>
                            <asp:ListItem Value="Penal">Jhon Diaz</asp:ListItem>


                        </asp:DropDownList>

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

                        <label>Accionante </label>
                        <asp:TextBox ID="Textaccionante" runat="server" CssClass=" form-control"></asp:TextBox>

                    </div>
                </div>

                <div class="col-md-6 ">
                    <div class="form-group">
                        <label for="exampleInputFile">Cargar Archivo</label>
                        <input type="file" id="exampleInputFile">
                    </div>
                </div>

            </div>
        </div>
        
                <div class="box box-primary">
            <div class="box-header with-border" style="background:#E0E6F8">
                <center>  
                    <asp:Button ID="Button1" style="background:#2E9AFE" Text="Crear Proceso"  runat="server"/>
                   
                </center>
            </div>
              </div>
    </div>

</asp:Content>
