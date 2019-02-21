<%@ Page Title="Hoja de Ruta" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="HojadeRuta.aspx.cs" Inherits="juefi2.Views.Vista1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Hoja de Ruta</title>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-13">
        <div class="box box-primary">
            <div class="toolbar-nav">
                <a href="/Views/principal.aspx">
                    <h5><i class="fa fa-home">&nbsp;</i>Inicio <span>>> </span><a href='#'><i class="fa fa-edit">&nbsp;</i>Hoja de Ruta</h5>
                    <br />
                </a>
            </div>
        </div>
    </div>

    <div class="box">
        <div class="box-header text-center">
            <b class="box-title text-center">Hoja de Ruta</b>
        </div>
        <section class="content">
            <div class="box-body">
                <div class="col-md-4">
                    <div class="form-group">

                        <label>Proceso</label><br />
                        <asp:DropDownList ID="Droproceso" CssClass="form-control select2 text-center" AppendDataBoundItems="true" runat="server" OnSelectedIndexChanged="Droproceso_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem Value="0"> ------- seleccioné ------ </asp:ListItem>

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



            <asp:Repeater ID="hojaruta" runat="server">
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
                                <th>folio</th>
                                <th>Actuacion</th>
                                <th>Observación</th>
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
                        <td><%#Eval("observacion")%></td>

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
                            <th>folio</th>
                            <th>Actuacion</th>
                            <th>Observación</th>
                        </tr>
                    </tfoot>

                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </section>
    </div>



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
                                    <asp:TextBox ID="Textfolio" runat="server" CssClass=" form-control"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-12  ">
                                <div class="form-group">
                                    <label>Actuación</label>
                                    <asp:TextBox ID="actuac" runat="server" class="form-control" Rows="3" placeholder="Enter ..."></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="modal-footer">
                            <button type="button" class="btn btn-default pull-left" data-dismiss="modal">Cerrar</button>
                            <asp:Button ID="guardar_hoja" runat="server" CssClass="btn btn-primary" OnClick="guardar_hoja_Click" Text="Guardar"></asp:Button>
                        </div>
                    </div>

                </div>

            </div>
        </div>

    </div>
</asp:Content>



