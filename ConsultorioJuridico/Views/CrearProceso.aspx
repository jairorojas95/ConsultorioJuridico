<%@ Page Title="" Language="C#" MasterPageFile="~/Views/pagina_maestra/paginamaestra.Master" AutoEventWireup="true" CodeBehind="CrearProceso.aspx.cs" Inherits="juefi2.Views.CrearProceso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="content-header">
        <label id="error" runat="server"></label>
    </div>
    <div class="content">
        <div class="col-md-8">

            <div class="box box-primary" style="background: #E0E6F8">
                <div class="box-header with-border">
                    <center> <h3 class="box-title">Crear Nuevo Proceso</h3> </center>
                </div>


                <div class="box-body">

                    <div class="col-md-6  ">
                        <div class="form-group">
                            <label>Tipo de Proceso</label>
                            <asp:DropDownList ID="droplisproceso" CssClass="form-control select2" runat="server"></asp:DropDownList>
                        </div>
                    </div>


                    <div class="col-md-6  ">
                        <div class="form-group">
                            <label>Asesor</label>

                            <asp:DropDownList ID="Dropasesor" CssClass="form-control select2" runat="server">
                            </asp:DropDownList>

                        </div>
                    </div>


                    <div class="col-md-6 ">
                        <div class="form-group">

                            <label>Accionado </label>
                            <asp:TextBox ID="Textaccionado" runat="server" CssClass=" form-control"></asp:TextBox>

                        </div>

                    </div>

                    <div class="col-md-6 ">
                        <div class="form-group">

                            <label>Accionante </label>
                            <asp:TextBox ID="Textaccionante" runat="server" CssClass=" form-control"></asp:TextBox>

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
                               <input type="file" name="UploadedFile"  id="file"/>
                        </div>  
                    </div>

                    <div class="col-md-6 ">
                        <div class="form-group">
                     <button type="button" class="btn btn-facebook " data-toggle="modal" data-target="#miModal">
                        Abrir modal
                    </button>

                            </div>
                       
                          </div>
                </div>

                <div class="box box-primary">
                    <div class="box-header with-border" style="background: #E0E6F8">
                        <center>  
                    <asp:Button ID="Button1" style="background:#2E9AFE" Text="Crear Proceso" OnClick="guardar" runat="server"/>
                   
                </center>
                    </div>
                </div>

            </div>

        </div>

        <div class="modal fade" id="miModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true" data-keyboard="false" data-backdrop="static">
            <div class="modal-dialog" role="document">
		<div class="modal-content">
			<div class="modal-header">
               <button type="button" class="close" data-dismiss="modal" aria-label="Close" >
					<span aria-hidden="true">&times;</span>
				</button>
				<h4 class="modal-title" id="myModalLabel">Esto es un modal</h4>
			</div>
			<div class="modal-body">
				Texto del modal
			</div>
        </div>
    </div>
</div>
</asp:Content>
