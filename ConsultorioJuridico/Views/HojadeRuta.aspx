<%@ Page Title="" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="HojadeRuta.aspx.cs" Inherits="juefi2.Views.Vista1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Hoja de Ruta</title>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="box">
        <div class="box-header">
            <h3 class="box-title text-center">Hoja de Ruta</h3>
        </div>
        <!-- /.box-header -->

        <div class="box-body">
            <div class="col-md-4  ">
                <div class="form-group">

                    <label>Proceso</label><br />
                    <asp:DropDownList ID="Droproceso" CssClass="form-control select2 text-center" AppendDataBoundItems="true" runat="server">
                        <asp:ListItem> ------- seleccioné ------ </asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <div class="col-md-6  ">
                <div class="form-group">
                    <br />
                    <asp:LinkButton ID="agregarhojaderuta" runat="server" CssClass="btn btn-primary btn-sm " OnCommand="agregarhojaderuta_Command" CommandArgument='<%=id %>' CommandName="id">Agregar Hoja de Ruta </asp:LinkButton>
                    <%-- <asp:LinkButton ID="Cierre" runat="server" CssClass="btn btn-primary btn-sm " data-toggle="modal" data-target="#modal_cierre" class="boton_1">Agregar Hoja de Ruta </asp:LinkButton>--%>
                </div>
            </div>
        </div>




        <table id="example1" class="table table-bordered table-striped">
            <thead>

                <tr>
                    <%--<asp:LinkButton ID="asignar" class="boton_1" ForeColor="SkyBlue" OnCommand="asignar_Command" CommandArgument='<%#Eval("idproceso")%>' CommandName="id">Asignar</asp:LinkButton>--%>
                </tr>

                <tr>
                    <th>Radicado</th>
                    <th>Tipo proceso</th>
                    <th>Accionante</th>
                    <th>Accionado</th>
                    <th>Fecha</th>
                </tr>

            </thead>
            <tbody>
                <tr>
                    <td>aaaaaa</td>
                    <td>bbbbbbbbbbbbbb></td>
                    <td>ccccccccccc></td>
                    <td>dddddddddddddd</td>
                    <td>eeeeeee</td>

                </tr>

            </tbody>
            <tfoot>
                <tr>
                    <th>Radicado</th>
                    <th>Tipo proceso</th>
                    <th>Accionante</th>
                    <th>Accionado</th>
                    <th>Fecha</th>
                </tr>
            </tfoot>
        </table>
    </div>
    <!-- /.box-body -->


    <div class="modal fade" id="modal_cierre" data-keyboard="false" data-backdrop="static">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title ">Hoja de Cierre</h4>

                    <div id="datos_ajax_register">
                        <div class="row">

                            <div class="col-md-6 ">
                                <br />
                                <div class="form-group">

                                    <label>Folio </label>
                                    <asp:TextBox ID="Textradicado" runat="server" CssClass=" form-control"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-12  ">
                                <div class="form-group">
                                    <label>Actuación</label>
                                    <textarea class="form-control" rows="3" placeholder="Enter ..."></textarea>
                                </div>
                            </div>
                        </div>

                        <div class="modal-footer">
                            <button type="button" class="btn btn-default pull-left" data-dismiss="modal">Cerrar</button>
                            <asp:Button ID="Asignar_Persona" runat="server" CssClass="btn btn-primary" Text="Asignar"></asp:Button>
                        </div>
                    </div>
                    <!-- /.modal-content -->
                </div>
                <!-- /.modal-dialog -->
            </div>
        </div>
        <!-- /.modal -->
    </div>

</asp:Content>



