<%@ Page Title="" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="CrearPersona.aspx.cs" Inherits="juefi2.Views.CrearPersona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 <div class="col-md-8">

        <div class="box box-primary" style="background:#E0E6F8">
            <div class="box-header with-border">
                
               <center> <h3 class="box-title">Crear Implicado</h3></center>
                   
            </div>



            <div class="box-body">

                <div class="col-md-6 ">
                    <div class="form-group">

                        <label>Primer Nombre </label>
                        <asp:TextBox ID="Txtnumero" runat="server" CssClass=" form-control"></asp:TextBox>

                    </div>

                </div>

                 <div class="col-md-6 ">
                <div class="form-group">

                    <label>Segundo Nombre</label>
                    <asp:TextBox ID="Textaccionado" runat="server" CssClass=" form-control"></asp:TextBox>

                </div>

            </div>

            <div class="col-md-6 ">
                <div class="form-group">

                    <label>Primer Apellido </label>
                    <asp:TextBox ID="Textaccionante" runat="server" CssClass=" form-control"></asp:TextBox>

                </div>
            </div>
                 <div class="col-md-6 ">
                <div class="form-group">

                    <label>Segundo Apellido </label>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass=" form-control"></asp:TextBox>

                </div>

            </div>

                     <div class="col-md-6  ">
                <div class="form-group">
                    <label>Tipo Documento</label>

                    <asp:DropDownList ID="DropDownList1" CssClass="form-control select2" runat="server">
                        <asp:ListItem Value="none">-------</asp:ListItem>
                         <asp:ListItem Value="Tarjeta">T.I.</asp:ListItem>
                        <asp:ListItem Value="Cedula">C.C.</asp:ListItem>
                        <asp:ListItem Value="CedulaEx">C.E.</asp:ListItem>                        
                    </asp:DropDownList>

                </div>
            </div>
           

            <div class="col-md-6  ">
                <div class="form-group">
                    <label>Tipo de Implicado</label>

                    <asp:DropDownList ID="DropIntegrantes" CssClass="form-control select2" runat="server">
                        <asp:ListItem Value="none">-------</asp:ListItem>
                        <asp:ListItem Value="Accionant">Accionante</asp:ListItem>
                        <asp:ListItem Value="Accionad">Accionado</asp:ListItem>
                    </asp:DropDownList>

                </div>
            </div>
           
            <div class="col-md-6 ">
                <div class="form-group">

                    <label>Identificacion </label>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass=" form-control"></asp:TextBox>

                </div>
            </div>

            
               
                 </div>

        </div>
      <div class="box box-primary">
            <div class="box-header with-border" style="background:#E0E6F8">
                <center>  
                   <asp:Button ID="Button1"  CssClass="btn btn-outline-primary" style="background:#2E9AFE" runat="server" Text="Crear persona"></asp:Button>
                </center>
            </div>
              </div>
    </div>

</asp:Content>
