<%@ Page Title="Registrar Proceso" EnableEventValidation="false" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="CrearProceso.aspx.cs" Inherits="juefi2.Views.CrearProceso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


        <div class="col-md-8 ">
        <div class="box box-primary">
            <div class="toolbar__nav">
                <a href="/Views/principal.aspx">
                    <h5><i class="fa fa-home">&nbsp;</i>Inicio <span>>> </span><a href='#'><i class="fa fa-institution">&nbsp;</i>Registrar Proceso</h5>
                    <br />
                </a>
            </div>
        </div>
    </div>
    
    
     <div class="content">
        <div class="col-md-8">
            <div class="box box-primary" >
                <div class="box-header with-border text-center">
                    <b class="box-title">Registrar Proceso</b>
                    </center>
                </div>
                <div class="box-body">

                    <div class="col-md-6  ">
                        <div class="form-group">
                            <label>Tipo de Proceso</label>
                            <asp:DropDownList ID="droplisproceso" CssClass="form-control " runat="server"></asp:DropDownList>
                        </div>
                    </div>

                    <div class="col-md-6  ">
                        <div class="form-group">
                            <label>Asesor</label>

                            <asp:DropDownList ID="Dropasesor" CssClass="form-control " runat="server">
                            </asp:DropDownList>
                        </div>
                    </div>



                    <div class="col-md-6  ">
                        <div class="form-group">
                            <label>Accionante</label>
                            <button type="button" class="btn btn-primary" style="margin-bottom: 3px;" data-toggle="modal" data-target="#lamodal">Crear </button>
                            <asp:DropDownList ID="Dropaccionante" CssClass="form-control select2 text-center" AppendDataBoundItems="true" runat="server" OnSelectedIndexChanged="sss">
                                <asp:ListItem Value="" Text="      ---- Seleccion ----     "> </asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>




                    <div class="col-md-6  ">
                        <div class="form-group">
                            <label>Accionado</label>
                            <button type="button" class="btn btn-primary" style="margin-bottom: 3px;" data-toggle="modal" data-target="#lamodal">Crear </button>
                            <asp:DropDownList ID="Dropaccionado" CssClass="form-control select2 text-center" AppendDataBoundItems="true" runat="server" OnSelectedIndexChanged="sss">
                                <asp:ListItem Value="" Text="      ---- Seleccion ----     "> </asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>





                    <div class="col-md-6 ">
                        <div class="form-group">

                            <label>Radicado </label>
                            <asp:TextBox ID="Textradicado" runat="server" CssClass=" form-control"></asp:TextBox>
                        </div>
                    </div>

                    <div class="col-md-6 ">
                        <div class="form-group">
                            <label for="file">Filename:</label>
                            <asp:FileUpload ID="MyFile" runat="server" />
                        </div>
                    </div>
                </div>

                <div class="box box-primary text-center">
                    <div class="box-header with-border">

                        <asp:Button ID="Btn_Guardar" CssClass="btn btn-primary" OnClick="Btn_Guardar_proceso_Click"  runat="server" Text="Registrar Proceso"></asp:Button>

                    </div>
                </div>

                <div class="modal fade" id="lamodal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true" data-keyboard="false" data-backdrop="static">
                    <div class="modal-dialog" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" runat="server" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span>
                                </button>
                                <h4 class="modal-title text-center" id="myModalLabel">Tipo Persona</h4>
                            </div>
                            <div class="modal-body">

                                <table>

                                    <tr>

                                        <th>
                                            <button type="button" runat="server" class="btn btn-facebook text-center " data-toggle="modal" data-target="#dataRegister2" data-dismiss="modal">Persona Jurídica</button></th>
                                        <th>
                                            <button type="button" runat="server" class="btn btn-facebook text-center " data-toggle="modal" data-target="#dataRegister" data-dismiss="modal">Persona Natural</button></th>
                                    </tr>

                                </table>

                            </div>
                            <div class="modal-footer">

                                <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
                            </div>
                        </div>
                    </div>
                </div>
                <form id="guardarDatos" method="post">
                    <div class="modal fade" id="dataRegister" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" data-keyboard="false" data-backdrop="static">
                        <div class="modal-dialog" role="document">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                    <h4 class="modal-title" id="exampleModalLabel">Datos Persona</h4>
                                </div>
                                <div class="box-body">
                                    <div class="modal-body">
                                        <div id="datos_ajax_register"></div>
                                        <div class="col-md-6  ">
                                            <label for="nom1" class="control-label">Primer Nombre</label>
                                            <asp:TextBox runat="server" type="text" class="form-control" ID="nombre1" name="codigo" MaxLength="45" />
                                        </div>
                                        <div class="col-md-6  ">
                                            <label for="nom2" class="control-label">Segundo Nombre</label>
                                            <asp:TextBox runat="server" type="text" class="form-control" ID="nombre2" name="nombre" MaxLength="45" />
                                        </div>
                                        <div class="col-md-6  ">
                                            <label for="apelli1" class="control-label">Primer Apellido</label>
                                            <asp:TextBox runat="server" type="text" class="form-control" ID="apellido1" name="moneda" MaxLength="45" />
                                        </div>
                                        <div class="col-md-6  ">
                                            <label for="apelli2" class="control-label">Segundo Apellido</label>
                                            <asp:TextBox runat="server" type="text" class="form-control" ID="apellido2" name="capital" MaxLength="45" />
                                        </div>
                                        <div class="col-md-6  ">
                                            <label>Tipo de documento</label>
                                            <asp:DropDownList ID="DropDowndocument" CssClass="form-control text-center " AppendDataBoundItems="true" runat="server">
                                                <asp:ListItem Value="" Text="      ---- Seleccion ----     "> </asp:ListItem>
                                            </asp:DropDownList>

                                        </div>

                                        <div class="col-md-6  ">
                                            <label for="T_doc" class="control-label">Documento</label>
                                            <asp:TextBox runat="server" type="text" class="form-control" ID="documento" name="continente" MaxLength="45" />
                                        </div>
                                        <div class="col-md-6  ">
                                            <label for="documento" class="control-label">Direccion</label>
                                            <asp:TextBox runat="server" type="text" class="form-control" ID="direccion" name="continente" MaxLength="45" />
                                        </div>
                                        <div class="col-md-6  ">
                                            <label for="tel" class="control-label">Telefono</label>
                                            <asp:TextBox runat="server" type="text" class="form-control" ID="telefono" name="continente" MaxLength="45" />
                                        </div>
                                    </div>

                                </div>

                            </div>
                            <div class="box box-primary text-center">
                                <br />
                                <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                                <asp:LinkButton ID="guardar_datos" class="btn btn-primary" runat="server" OnClick="guardar_datos_Click">Guardar datos</asp:LinkButton>
                                <button type="button" class="btn btn-default" data-toggle="modal" data-dismiss="modal" data-target="#lamodal">Regresar  </button>
                                <br />
                            </div>
                        </div>

                    </div>

                    <div class="modal fade" id="dataRegister2" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" data-keyboard="false" data-backdrop="static">
                        <div class="modal-dialog" role="document">
                            <div class="modal-content">
                                <div class="modal-header">

                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                    <h4 class="modal-title" id="exampleModalLabel2">Datos Persona</h4>
                                </div>
                                <div class="modal-body">
                                    <div id="datos_ajax_register2"></div>
                                    <div class="col-md-6  ">
                                        <label for="tel" class="control-label">Nit</label>
                                        <asp:TextBox runat="server" type="text" class="form-control" ID="nit" name="continente" MaxLength="45" />
                                    </div>
                                    <div class="col-md-6  ">
                                        <label for="tel" class="control-label">Empresa</label>
                                        <asp:TextBox runat="server" type="text" class="form-control" ID="empresa" name="continente" MaxLength="45" />
                                    </div>
                                    <br />
                                   
                                    <div class="col-md-6  ">
                                            <label>Tipo de documento</label>
                                            <asp:DropDownList ID="DropDownRepresentante" CssClass="form-control " class="box box-primary text-center" AppendDataBoundItems="true" runat="server">
                                                <asp:ListItem Value="" Text="      ---- Seleccion ----     "> </asp:ListItem>
                                            </asp:DropDownList>

                                        </div>
                                    
                                </div>
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <div class="box box-primary text-center">
                                    <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                                    <asp:LinkButton ID="Guardar_juridico" class="btn btn-primary" runat="server" OnClick="Guardar_juridico_Click"> Guardar datos</asp:LinkButton>
                                    <button type="button" class="btn btn-default" data-toggle="modal" data-dismiss="modal" data-target="#lamodal">Regresar  </button>
                                   
                                </div> 
                            </div>
                        </div>
                    </div>
            </div>


        </div>
    </div>

    <%--<script>
    $("#guardar_datos").click(function () {
        $.ajax({
            url: 'Proceso/registrarpersonatest',
            type: 'post',
            cache: false,
            data: getData(),
            success: function (retorno) {

                alert('exxito');
            },
            error: function (d) {
                'muestrele algo diciendo error'
            }
        });

    });

    function getData() {
        return {
            Nombre1: $("#nombre1").val(),
            Nombre2: $("#nombre2").val(),
            Apellido1: $("#apellido1").val(),
            DropDowndocument: $("#DropDowndocument").val(),
            Documento: $("#documento").val(),
            Direccion: $("#direccion").val(),
            Telefono: $("#telefono").val()
        };
    }
</script>--%>
</asp:Content>


