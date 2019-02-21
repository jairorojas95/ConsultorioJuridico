<%@ Page Title="Crear persona" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="CrearPersona.aspx.cs" Inherits="juefi2.Views.CrearPersona" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    
       <div class="col-md-8 ">
        <div class="box box-primary">
            <div class="toolbar__nav">
                <a href="/Views/principal.aspx">
                    <h5><i class="fa fa-home"></i>Inicio <span>>> </span><a href='#'><i class="fa fa-child"></i>Crear persona</h5>
                    <br />
                </a>
            </div>
        </div>
    </div>
    
    
    
    
    
    
    <div class="col-md-8">

        <div class="box box-primary" >
            <div class="box-header with-border">

                <center> <b class="box-title">Crear persona</b></center>

            </div>



            <div class="box-body">

                <div class="col-md-6 ">
                    <div class="form-group">

                        <label>Primer Nombre </label>
                        <asp:TextBox ID="nombre1" runat="server" CssClass=" form-control"></asp:TextBox>

                    </div>

                </div>

                <div class="col-md-6 ">
                    <div class="form-group">

                        <label>Segundo Nombre</label>
                        <asp:TextBox ID="nombre2" runat="server" CssClass=" form-control"></asp:TextBox>

                    </div>

                </div>

                <div class="col-md-6 ">
                    <div class="form-group">

                        <label>Primer Apellido </label>
                        <asp:TextBox ID="apellido1" runat="server" CssClass=" form-control"></asp:TextBox>

                    </div>
                </div>
                <div class="col-md-6 ">
                    <div class="form-group">

                        <label>Segundo Apellido </label>
                        <asp:TextBox ID="apellido2" runat="server" CssClass=" form-control"></asp:TextBox>

                    </div>

                </div>


                <div class="col-md-6 ">
                    <div class="form-group">

                        <label>Usuario </label>
                        <asp:TextBox ID="usuario" runat="server" CssClass=" form-control"></asp:TextBox>

                    </div>
                </div>



                <div class="col-md-6 ">
                    <div class="form-group">

                        <label>Correo </label>
                        <asp:TextBox ID="email" runat="server" CssClass=" form-control"></asp:TextBox>

                    </div>
                </div>

                <div class="col-md-6 ">
                    <div class="form-group">

                        <label>Contraseña </label>
                        <asp:TextBox ID="contrasena" runat="server" TextMode="password" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>

                    </div>
                </div>
                <div class="col-md-6 ">
                    <div class="form-group">

                        <label>Confirmar contraseña </label>
                        <asp:TextBox ID="contrasena2" runat="server" TextMode="password" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>

                    </div>
                </div>

                <div class="col-md-6  ">
                    <div class="form-group">
                        <label>Rol</label>

                        <asp:DropDownList ID="DropRol" CssClass="form-control select2" runat="server">
                        </asp:DropDownList>

                    </div>
                </div>



            </div>

        </div>
        <div class="box box-primary">
            <div class="box-header with-border" >
                <center>  
                   <asp:Button ID="Button1"  CssClass="btn btn-primary" OnClick="guardar"  runat="server" Text="Crear Persona"></asp:Button>
                </center>
            </div>
        </div>
    </div>

</asp:Content>
