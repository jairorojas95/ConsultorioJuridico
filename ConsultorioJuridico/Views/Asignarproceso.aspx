<%@ Page Title="Asignar Proceso" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="Asignarproceso.aspx.cs" Inherits="juefi2.Views.Asignarproceso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
    </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <div class="col-md-12 ">
        <div class="box box-primary">
            <div class="toolbar__nav">
                <a href="/Views/principal.aspx">
                    <h5><i class="fa fa-home">&nbsp;</i>Inicio <span>>> </span><a href='#'><i class="fa fa-institution">&nbsp;</i>Asignar Proceso</h5>
                    <br />
                </a>
            </div>
        </div>
    </div>
    <br />

    <br />
    
    <section class="content">
        <div class="box">
            <div class="box-header text-center">
                <b class="box-title">Asignar Proceso</b>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
                <asp:Repeater ID="asignarproceso" runat="server">
                    <HeaderTemplate>
                        <table id="example1" class="table table-bordered table-striped">
                            <thead>
                                <tr>
                                    <th>N°</th>
                                    <th>Nombre</th>
                                    <th>Semestre</th>
                                     <th>Cantidad</th>
                                  <%--  <th>accionante</th>
                                    <th>accionado</th>
                                    <th>Aseso</th>
                                    <th>Tipo proceso</th>
                                    <th>Asignar</th>--%>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>

                            <td><%#Eval("idusuario")%></td>
                            <td><%#Eval("nombre")%></td>
                            <td><%#Eval("semestre")%></td>
                             <td><%#Eval("cantidad")%></td>
                            <%--  <td><%#Eval("nombre2")%></td>
                            <td><%#Eval("accionante")%></td>
                            <td><%#Eval("accionado")%></td>
                            <td><%#Eval("asesor")%></td>
                            <td><%#Eval("nombre_tipo")%></td>--%>
                            <td>
                                <asp:LinkButton ID="asignar" runat="server" CssClass="btn btn-primary btn-sm " OnCommand="asignar_Command" CommandArgument='<%#Eval("idusuario")%>' CommandName="id">Asignar</asp:LinkButton>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </tbody>
                    <tfoot>
                        <tr>
                            <th>N°</th>
                            <th>Nombre</th>
                            <th>Semestre</th>
                              <th>Cantidad</th>
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
                    <h4 class="modal-title ">Asignar Proceso</h4>
                    <div class="col-md-6  ">
                        <div class="form-group">
                            <br />
                            <label>Proceso</label><br />
                            <asp:DropDownList ID="droplisproceso" CssClass="form-control select2 text-center" AppendDataBoundItems="true"  sAppendDataBoundItems="true" runat="server" required>
                              <asp:ListItem Value=""> ---- Seleccion ----</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>


                </div>

                <div class="modal-footer">
                    <button type="button" class="btn btn-default pull-left" data-dismiss="modal">Cerrar</button>
                    <asp:Button ID="Asignar_Persona" runat="server" OnClick="guardar_datos_Click" CssClass="btn btn-primary" Text="Asignar"></asp:Button>
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
    <!-- /.modal -->

</asp:Content>
