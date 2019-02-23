<%@ Page Title="" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="consultarhoja-cierre-estudinate.aspx.cs" Inherits="juefi2.Views.consultarhoja_cierre_estudinate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-13 ">
        <div class="box box-primary">
            <div class="toolbar__nav">
                <a href="/Views/principal.aspx">
                    <h5><i class="fa fa-home">&nbsp;</i>Inicio <span>>> </span><a href='#'><i class="fa fa-object-group">&nbsp;</i>Consultar Hoja de Cierre</h5>
                    <br />
                </a>
            </div>
        </div>
    </div>

    <div class="box">
        <div class="box-header text-center">
            <b class="box-title">Consultar Hoja de Cierre</b>
        </div>
        <section class="content">
                  <asp:Repeater ID="diagnostico" runat="server">
                <HeaderTemplate>
                    <table id="example1" class="table table-bordered table-striped">
                        <thead>
                            <tr>
                                <th>N°</th>
                                <th>Radicado</th>
                                <th>Tipo proceso</th>
                                <th>accionante</th>
                                <th>accionado</th>
                                <th>Fecha Cierre</th>
                                <th>Terminacion</th>
                                <th>Asunto</th>
                                <th>Observación</th>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>

                    <tr>

                        <td><%#Eval("idhoja_cierre")%></td>
                        <td><%#Eval("radicado")%></td>
                        <td><%#Eval("proceso_tipo")%></td>
                        <td><%#Eval("accionante")%></td>
                        <td><%#Eval("accionado")%></td>
                        <td><%#Eval("fecha")%></td>
                        <td><%#Eval("terminancion")%></td>
                        <td><%#Eval("asunto")%></td>
                        <td><%#Eval("observacion")%></td>        

                        

                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </tbody>
                    <tfoot>
                        <tr>
                                <th>N°</th>
                                <th>Radicado</th>
                                <th>Tipo proceso</th>
                                <th>accionante</th>
                                <th>accionado</th>
                                <th>Fecha Cierre</th>
                                <th>Terminacion</th>
                                <th>Asunto</th>
                                <th>Observación</th>
                        </tr>
                    </tfoot>

                    </table>
                </FooterTemplate>
            </asp:Repeater>
    </div>
    </section>
    
    
    
</asp:Content>
