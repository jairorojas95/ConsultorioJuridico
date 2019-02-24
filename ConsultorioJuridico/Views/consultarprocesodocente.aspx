<%@ Page Title="" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="consultarprocesodocente.aspx.cs" Inherits="juefi2.Views.consultarprocesodocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    
      <div class="col-md-12 ">
        <div class="box box-primary">
            <div class="toolbar__nav">
                <a href="/Views/principal.aspx">
                    <h5><i class="fa fa-home">&nbsp;</i>Inicio <span>>> </span><a href='#'><i class="fa fa-search-minus">&nbsp;</i>Consultar Proceso</h5>
                    <br />
                </a>
            </div>
        </div>
    </div>
     <br />


    <section class="content">
        <div class="box">
            <div class="box-header text-center">
                <b class="box-title" >Consultar Proceso</b>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
                <asp:Repeater ID="consultarproceso" runat="server">
                    <HeaderTemplate>
                        <table id="example1" class="table table-bordered table-striped">
                            <thead>
                                <tr>
                                    <th>N°</th>
                                    <th>Radicado</th>
                                    <th>accionante</th>
                                    <th>accionado</th>
                                    <th>Estudiante</th>
                                    <th>Tipo proceso</th>
                                     <th>Archivo</th>
                                   <%-- <th>edit</th>--%>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <%--<td><%#Eval("idproceso")%></td>
                            <td><%#Eval("radicado_proceso")%></td>
                            <td><%#Eval("accionante")%></td>
                            <td><%#Eval("accionado")%></td>
                            <td><%#Eval("asesor")%></td>
                            <td><%#Eval("nombre_tipo")%></td>--%>
                            <td><%#Eval("idproceso")%></td>
                            <td><%#Eval("radicado_proceso")%></td>
                            <td><%#Eval("accionante")%></td>
                            <td><%#Eval("accionado")%></td>
                            <td><%#Eval("asesor")%></td>
                            <td><%#Eval("nombre_tipo")%></td>
                                <td> <a href='<%# Page.ResolveUrl( Eval("archivos").ToString()) %>'  target="_blank">Ver/Descargar</a></td>
                             </td>
                          <%--td><button type="button" class="fa fa-pencil" data-toggle="modal" data-target="#modal-default"></button></td>--%>
                           <%-- <td><asp:LinkButton ID="Editar" runat="server" CssClass="btn btn-primary btn-sm " data-toggle="modal" data-target="#modal-default"><i class="fa fa-pencil"></i></asp:LinkButton>
                                <asp:LinkButton ID="asignar" runat="server" CssClass="btn btn-primary btn-sm " OnCommand="asignar_Command" CommandArgument='<%#Eval("idproceso")%>' CommandName="id">Asignar</asp:LinkButton>
                            </td>--%>
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
                            <th>Estudiante</th>
                            <th>Tipo proceso</th>
                             <th>Archivo</th>
                          <%--  <th>edit</th>--%>
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
