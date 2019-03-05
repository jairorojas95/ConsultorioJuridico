<%@ Page Title="Consultar Hoja de Cierre" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="Consultarhojacierre.aspx.cs" Inherits="juefi2.Views.Consultarhojacierre" %>
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
            <div class="box-body">
                <div class="col-md-4  ">
                    <div class="form-group">

                        <label>Estudiantes</label><br />
                        <asp:DropDownList ID="Dropestudiante" CssClass="form-control select2 text-center" AppendDataBoundItems="true" runat="server" OnSelectedIndexChanged="Dropestudiante_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem Value="0"> ------- seleccioné ------ </asp:ListItem>

                        </asp:DropDownList>
                    </div>
                </div>

            </div>


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
                        <td>
                            <asp:LinkButton ID="aceptar" runat="server" CssClass="btn btn-primary btn-sm" OnCommand="aceptar_Command1" CommandArgument='<%#Eval("idproceso")%>' CommandName="id">Aceptar </asp:LinkButton>
                            <asp:LinkButton ID="observacion" runat="server" CssClass="btn btn-primary btn-sm " OnCommand="observacion_Command" CommandArgument='<%#Eval("idhoja_cierre")%>' CommandName="id">Observacion</asp:LinkButton>
                            
                        </td>

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
    
    

    <div class="modal fade" id="modal-default22" data-keyboard="false" data-backdrop="static">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title text-center">Hacer Observacion</h4>

                    <div class="col-md-12  ">
                        <div class="form-group">
                            <label>Observación</label>
                            <asp:TextBox ID="observa" runat="server" class="form-control" Rows="3" placeholder="Enter ..."></asp:TextBox>
                        </div>
                    </div>

                </div>

                <div class="modal-footer">
                    <button type="button" class="btn btn-default pull-left" data-dismiss="modal">Close</button>
                    <asp:Button ID="Agregar_observacion" runat="server" OnClick="Agregar_observacion_Click" CssClass="btn btn-primary" Text="Guardar"></asp:Button>
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
</asp:Content>
