<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="juefi2.Views.usuario.registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registrarse</title>

     <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">

<link href="../../Content/stilos/cssinicio/bootstrap.min.css" rel="stylesheet" />

<link href="../../Content/stilos/cssinicio/login.css" rel="stylesheet" />
<link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Roboto:300,600">

    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.0.9/css/all.css" integrity="sha384-5SOiIsAziJl6AWe0HWRKTXlfcSHKmYV4RBF18PPJ173Kzn7jzMyFuTtk8JA7QQG1" crossorigin="anonymous">
    <link href='http://fonts.googleapis.com/css?family=Grand+Hotel' rel='stylesheet' type='text/css'>
   
    <script src="http://code.jquery.com/jquery-latest.js"></script>
    <script src="../../Scripts/jsinicio/main.js"></script>
    
    <link href="../../Content/stilos/cssinicio/fontawesome-all.css" rel="stylesheet" />


</head>
<body>
   <header>
 
    <!-- Brand and toggle get grouped for better mobile display -->
    
            <input type="checkbox"  id="btn-menu"/>
            <label  for="btn-menu" class="icon-menu"></label>
    <!-- Collect the nav links, forms, and other content for toggling -->
   <nav  class="menu">
      <ul >
        
           <li >
                <a href="../../inicio.html">
                    <i class="fas fa-home"></i>
                  Inicio
                </a>
            </li>
    
          <%--  <li >
                <a href="#">
                    <i class="fas fa-gamepad"></i>
                    Acerca del Juego
                </a>
            </li>--%>
          <%--   <li>
                <a href="#">
                    <i class="far fa-envelope"></i>
                Contactanos 
                </a>
            </li>--%>
            
        <li>
            <a href="../usuario/login.aspx" class="btn btn-danger btn-round    ">
                <i class="fas fa-user-circle"></i> Iniciar Sesión
            </a>
        </li>
       </ul>

   </nav>

</header>




    <div class="container">





        <div class="row">
            <div class="col-md-7 col-md-offset-3  login-form text-center">
                <br />
               <h1 style="text-align:center;"><i class="fa fa-lg fa-fw fa-user"></i>Registro</h1>
                <br />
              
                <form id="form2" runat="server">

                    
                   
                    <div class="row">
                        <div class="col-md-5 col-md-offset-1">

                            <div class="input-group">

                                <span class="input-group-addon  "><i class="fas fa-user"></i></span>
                                <asp:TextBox ID="nombre1" runat="server" CssClass="form-control" placeholder="Primer Nombre"></asp:TextBox>

                            </div>

                            <div class="input-group">
                                <span class="input-group-addon"><i class="fas fa-user"></i></span>
                                <asp:TextBox ID="apellido1" runat="server" CssClass="form-control" placeholder="Primer Apellido"></asp:TextBox>

                            </div>
                                   <div class="input-group">
                                <span class="input-group-addon"><i class="fas fa-plus-square"></i></span>
                                <asp:TextBox ID="semestre" runat="server" CssClass="form-control" placeholder="Semestre"></asp:TextBox>

                            </div>

                            <div class="input-group">
                                <span class="input-group-addon"><i class="fas fa-at"></i></span>

                                <asp:TextBox ID="email" runat="server" CssClass="form-control" placeholder="Correo Electronico" TextMode="email"></asp:TextBox>
                            </div>

                            <div class="input-group">
                                <span class="input-group-addon">
                                    <i class="fas fa-unlock"></i>
                                </span>
                                <asp:TextBox ID="contrasena" runat="server" TextMode="password" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>

                            </div>

                        </div>


                        <div class="col-md-5 ">

                            <div class="input-group">
                                <span class="input-group-addon"><i class="fas fa-user-plus"></i></span>

                                <asp:TextBox ID="nombre2" runat="server" CssClass="form-control" placeholder="Segundo Nombre"></asp:TextBox>

                            </div>
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fas fa-user-plus"></i></span>
                                <asp:TextBox ID="apellido2" runat="server" CssClass="form-control" placeholder="Segundo Apellido"></asp:TextBox>

                            </div>



                            <div class="input-group">
                                <span class="input-group-addon">
                                    <i class="fas fa-user-secret"></i>
                                </span>
                                <asp:TextBox ID="usuario" runat="server" CssClass="form-control" placeholder="Usuario"></asp:TextBox>

                            </div>



                            <div class="input-group">
                                <span class="input-group-addon">
                                    <i class="fas fa-unlock"></i>
                                </span>
                                <asp:TextBox ID="conficontrasena" TextMode="password" runat="server" CssClass="form-control" placeholder=" Confirmar Contraseña"></asp:TextBox>

                            </div>

                        </div>
                    </div>

                    <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-danger btn-round  " OnClick="LinkButton1_Click"><span class="glyphicon glyphicon-log-in"></span> Registrarse</asp:LinkButton>

                </form>
            </div>

        </div>
    </div>


</body>
</html>
