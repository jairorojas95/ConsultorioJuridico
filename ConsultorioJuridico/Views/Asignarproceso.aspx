<%@ Page Title="" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="Asignarproceso.aspx.cs" Inherits="juefi2.Views.Asignarproceso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content">
        <div class="box">
            <div class="box-header text-center">
                <h3 class="box-title">Asignar Proceso</h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
                <asp:Repeater ID="asignarproceso" runat="server">
                    <HeaderTemplate>
                        <table id="example1" class="table table-bordered table-striped">
                            <thead>
                                <tr>
                                    <th>Nombre</th>
                                    <th>Semestre</th>
                                    <%-- <th>Radicado</th>
                                    <th>accionante</th>
                                    <th>accionado</th>
                                    <th>Aseso</th>
                                    <th>Tipo proceso</th>--%>
                                    <th>Asignar</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>

                            <td><%#Eval("nombre")%></td>
                            <td><%#Eval("semestre")%></td>
                            <%--  <td><%#Eval("nombre2")%></td>
                            <td><%#Eval("accionante")%></td>
                            <td><%#Eval("accionado")%></td>
                            <td><%#Eval("asesor")%></td>
                            <td><%#Eval("nombre_tipo")%></td>--%>
                            <td>
                                <asp:LinkButton ID="Editar" runat="server" CssClass="btn btn-primary btn-sm " data-toggle="modal" data-target="#modal-default"><i class="fa fa-pencil"></i></asp:LinkButton></td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </tbody>
                    <tfoot>
                        <tr>
                            <th>Nombre</th>
                            <th>Semestre</th>
                            <%--  <th>Radicado</th>
                            <th>accionante</th>
                            <th>accionado</th>
                            <th>Aseso</th>
                            <th>Tipo proceso</th>--%>
                            <th>Asignar</th>
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




    <div class="modal fade" id="modal-default" data-keyboard="false" data-backdrop="static">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title">Default Modal</h4>
                </div>
                <div class="modal-body">
                    <p>One fine body&hellip;</p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default pull-left" data-dismiss="modal">Close</button>
                    <button type="button" class="btn btn-primary">Save changes</button>
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
    <!-- /.modal -->

</asp:Content>
