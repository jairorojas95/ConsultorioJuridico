<%@ Page Title="" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="HojaCierre.aspx.cs" Inherits="juefi2.Views.HojaCierre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Hoja de Cierre</title>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <div class="col-md-8 ">
        <div class="box box-primary">
            <div class="toolbar__nav">
                <a href="/Views/principal.aspx">
                    <h5><i class="fa fa-home">&nbsp;</i>Inicio <span>>> </span><a href='#'><i class="fa  fa-clipboard">&nbsp;</i>Hoja de Cierre</h5>
                    <br />
                </a>
            </div>
        </div>
    </div>
    <br />

    <br />


      <div class="col-md-8">
        <div class="box box-primary" >
            <div class="box-header with-border">
                <center><b class="box-title">Hoja de Cierre</b></center>
            </div>
            <div class="box-body">
                <div class="col-md-6 ">
                    <div class="form-group">
                        <label>Proceso</label>
                        <asp:DropDownList ID="Droproceso" CssClass="form-control select2" AppendDataBoundItems="true" runat="server" required>
                            <asp:ListItem >------seleccioné------</asp:ListItem>
                            </asp:DropDownList>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label>Fecha de la Terminación</label>
                        <div class="input-group">
                            <div class="input-group-addon">
                                <i class="fa fa-calendar"></i>
                            </div>
                            <asp:TextBox  runat="server" TextMode="Date" CssClass="form-control" ID="datepicker1" required />
                        </div>
                    </div>
                </div>
                
                <div class="col-md-6 ">
                    <div class="form-group">
                        <br />
                        <asp:LinkButton ID="Editar" runat="server" CssClass="btn btn-primary btn-sm " data-toggle="modal" data-target="#modal-default" Text ="Agregar Motivo de Terminacion"></asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>

       
        <div class="modal fade" id="modal-default" data-keyboard="false" data-backdrop="static">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title ">Motivo de terminación</h4>
                        <div class="col-md-12">
                            <div class="form-group">
                                <div class="form-group">
                                    <label for="exampleFormControlTextarea1">Motivo de Terminación</label>
                                    <asp:TextBox runat="server" CssClass="form-control rounded-0" ID="terminacion" TextMode="MultiLine" Rows="10" required></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <label for="comment">Naturaleza del Asunto</label>
                                    <asp:TextBox  runat="server" CssClass="form-control" Rows="5" TextMode="MultiLine" ID="asunto" required></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default pull-left" data-dismiss="modal">Cerrar</button>
                        <asp:Button ID="Asignar_Persona" runat="server" OnClick="Asignar_Persona_Click" CssClass="btn btn-primary" Text="Asignar"></asp:Button>
                    </div>
                </div>
                <!-- /.modal-content -->
            </div>
            <!-- /.modal-dialog -->
        </div>
    </div>
</asp:Content>
