using juefi2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace juefi2.Controllers
{
    public class UsuarioController : ApiController
    {


        public UsuarioModel Usu = new UsuarioModel();





        public DataTable Login(UsuarioModel user)

        {

            return user.ConsultarCuenta(user);

        }

        public bool usuarioExiste(string obj)
        {
            return Usu.Validarusuario(obj);
        }
        public bool emailExiste(string obj)
        {
            return Usu.Validaremail(obj);
        }
        public bool Registrarse(UsuarioModel mod)
        {

            Usu.registrarusuario(mod);
            return true;
        }

    }



}
