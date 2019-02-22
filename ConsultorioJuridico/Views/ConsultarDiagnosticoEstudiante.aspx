<%@ Page Title="Consultar Diagnostico" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="ConsultarDiagnosticoEstudiante.aspx.cs" Inherits="juefi2.Views.ConsultarDiagnosticoEstudiante" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-12 ">
        <div class="box box-primary">
            <div class="toolbar__nav">
                <a href="/Views/principal.aspx">
                    <h5><i class="fa fa-home">&nbsp;</i>Inicio <span>>> </span><a href='#'><i class="fa fa-file-zip-o">&nbsp;</i>Consultar Diagnostico</h5>
                    <br />
                </a>
            </div>
        </div>
    </div>
    <br />

    <section class="content">
        <div class="box">
            <div class="box-header text-center">
                <b class="box-title">Consultar Diagnostico</b>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
                <asp:Repeater ID="diagnostico" runat="server">
                    <HeaderTemplate>
                        <table id="example1" class="table table-bordered table-striped">
                            <thead>
                                <tr>
                                    <th>N°</th>
                                    <th>Radicado</th>
                                    <th>accionante</th>
                                    <th>accionado</th>
                                    <th>Aseso</th>
                                    <th>Tipo proceso</th>
                                    <th>Fecha diagnostico</th>
                                    <th>Archivo</th>
                                    <th>Observación</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("iddiagnostico")%></td>
                            <td><%#Eval("radicado_proceso")%></td>
                            <td><%#Eval("accionante")%></td>
                            <td><%#Eval("accionado")%></td>
                            <td><%#Eval("asesor")%></td>
                            <td><%#Eval("nombre_tipo")%></td>
                            <td><%#Eval("fecha")%></td>
                            <td><a href='<%# Page.ResolveUrl( Eval("archivo").ToString()) %>' target="_blank">Ver/Descargar</a></td>

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
                            <th>Aseso</th>
                            <th>Tipo proceso</th>
                            <th>Fecha diagnostico</th>
                            <th>Archivo</th>
                            <th>Observación</th>
                        </tr>
                    </tfoot>

                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
            <!-- /.box-body -->
        </div>
        <!-- /.box -->
    </section>


</asp:Content>
