<%@ Page Title="" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="ConsultarHojaruta.aspx.cs" Inherits="juefi2.Views.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Consultar Hoja de Ruta</title>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="box">
        <div class="box-header">
            <h3 class="box-title text-center">Hoja de Ruta</h3>
        </div>


        <section class="content">
            <div class="box-body">
                <div class="col-md-4  ">
                    <div class="form-group">

                        <label>Estudiantes</label><br />
                        <asp:DropDownList ID="Dropestudiante" CssClass="form-control select2 text-center" AppendDataBoundItems="true" runat="server" OnSelectedIndexChanged="Dropestudiante_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem Value="0"> ------- seleccioné ------ </asp:ListItem>

                        </asp:DropDownList>
                    </div>
                </div>

               <div class="col-md-4  ">
                    <div class="form-group">

                        <label>Proceso</label><br />
                        <asp:DropDownList ID="Droproceso" CssClass="form-control select2 text-center" AppendDataBoundItems="true" runat="server" OnSelectedIndexChanged="Droproceso_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem Value="0"> ------- seleccioné ------ </asp:ListItem>

                        </asp:DropDownList>
                    </div>
                </div>
            </div>



            <asp:Repeater ID="hojaruta" runat="server">
                <HeaderTemplate>
                    <table id="example1" class="table table-bordered table-striped">
                        <thead>
                            <tr>
                                <th>N°</th>
                                <th>Radicado</th>
                                <th>accionante</th>
                                <th>accionado</th>
                                <th>Asesor</th>
                                <th>Tipo proceso</th>
                                <th>folio</th>
                                <th>Actuacion</th>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>

                    <tr>
                        
                        <td><%#Eval("idproceso")%></td>
                        <td><%#Eval("radicado_proceso")%></td>
                        <td><%#Eval("accionante")%></td>
                        <td><%#Eval("accionado")%></td>
                        <td><%#Eval("asesor")%></td>
                        <td><%#Eval("nombre_tipo")%></td>
                        <td><%#Eval("folio")%></td>
                        <td><%#Eval("actuacion")%></td>

                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </tbody>
                    <tfoot>
                        <tr>
                            <th>N°</th>
                            <th>Radicado</th>
                            <th>accionante</th>
                            <th>accionado</th>
                            <th>Asesor</th>
                            <th>Tipo proceso</th>
                            <th>folio</th>
                            <th>Actuacion</th>
                        </tr>
                    </tfoot>

                    </table>
                </FooterTemplate>
            </asp:Repeater>
    </div>
    </section>
</asp:Content>
