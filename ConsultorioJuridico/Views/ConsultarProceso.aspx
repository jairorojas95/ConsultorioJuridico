<%@ Page Title="" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="ConsultarProceso.aspx.cs" Inherits="juefi2.Views.ConsultarProceso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function botondelmodel() {
            console.log("si está llegando");
            document.getElementById('idmodelddd').click();
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-8">

        <div class="box box-primary" style="background: #E0E6F8">
            <div class="box-header with-border">
                <center> <h3 class="box-title">Consultar Proceso</h3> </center>
            </div>

            <div class="col-lg-12">

                <div class="table-responsive">
                    <table class="table table-bordered" id="dataTable">
                        <thead>
                            <tr class="alert alert-secondary">
                                <th>N°</th>
                                <th>Radicado</th>
                                <th>accionante</th>
                                <th>accionado</th>
                                <th>Asesor</th>
                                <th>Tipo proceso</th>
                                <th>edit </th>

                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="consultaproceso" runat="server" OnItemCommand="consultaproceso_ItemCommand">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("idproceso") %></td>
                                        <td><%# Eval("radicado_proceso") %></td>
                                        <td><%# Eval("accionante") %></td>
                                        <td><%# Eval("accionado") %></td>
                                        <td><%# Eval("asesor") %></td>
                                        <td><%# Eval("nombre_tipo") %></td>

                                        <td>
                                            <asp:LinkButton ID="botonprueba" runat="server" hrf="#modal-default" Title="Editar proceso" CssClass="btn btn-success fa fa-fw fa-plus-square" CommandArgument='<%# Eval("idproceso") %>' CommandName="edit"> </asp:LinkButton></td>
                                        <td></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>

                <a href="#modal-default" class="btn btn-default" id="idmodelddd" data-toggle="modal" data-target="#modal-default">+</a>

                <div class="modal fade" id="modal-default">
                    <div class="modal-dialog">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span></button>
                                <h4 class="modal-title">Default Modal</h4>
                            </div>
                            <div class="modal-body">

                                <label id="labelidproceso" runat="server"></label>

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
            </div>
</asp:Content>
