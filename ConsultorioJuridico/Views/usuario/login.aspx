<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="juefi2.Views.usuario.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Iniciar Sesión</title>

    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">

    <link href="../../Content/stilos/cssinicio/bootstrap.min.css" rel="stylesheet" />

    <link href="../../Content/stilos/cssinicio/login.css" rel="stylesheet" />
    <link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Roboto:300,600">

    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.0.9/css/all.css" integrity="sha384-5SOiIsAziJl6AWe0HWRKTXlfcSHKmYV4RBF18PPJ173Kzn7jzMyFuTtk8JA7QQG1" crossorigin="anonymous">
    <link href='http://fonts.googleapis.com/css?family=Grand+Hotel' rel='stylesheet' type='text/css'>

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
    
            <li >
                <a href="#">
                    <i class="fas fa-gamepad"></i>
                    Acerca del Juego
                </a>
            </li>
             <li>
                <a href="#">
                    <i class="far fa-envelope"></i>
                Contactanos 
                </a>
            </li>
            
        <li>
           
            <a href="../Usuario/registro.aspx" class="btn btn-danger btn-round    ">
                <i class="fas fa-user-plus"></i> Registrarse
            </a>
        </li>
       </ul>

   </nav>

</header>

    <div class="container">
	<div class="col-md-3 col-md-offset-4 login-form text-center">
        <br />

	<img src="../../Content/imagenes/imagesinicio/logo.png"  height="50%" width="50%"/>
        <br />
         <br />

	<form  runat="server">
   
   <div class="input-group">
    <span class="input-group-addon">
     <i class="fas fa-user"></i>
           </span>
   
<asp:TextBox ID="usuario" runat="server"  Cssclass="form-control" placeholder="Usuario"    ></asp:TextBox>
    </div>
    
    <div class="input-group">
    <span class="input-group-addon">
     <i class="fas fa-lock-open"></i>
           </span>
  <asp:TextBox ID="contrasena" runat="server"   TextMode="password" Cssclass="form-control"  placeholder="Contraseña"  ></asp:TextBox>
    </div>
  
    <asp:LinkButton ID="LinkButton1" runat="server"  Cssclass="btn btn-danger btn-round  "  OnClick="LinkButton1_Click"  ><span class="glyphicon glyphicon-log-in"></span> Iniciar Sesión</asp:LinkButton>
    </form>
	</div>
</div>    
    <script src="../../Scripts/jsinicio/bootstrap.min.js"></script>
    <script src="../../Scripts/jsinicio/jquery-1.10.2.js"></script>
</body>
</html>
