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
    public class MenuController : ApiController
    {
        public MenuModel useres = new MenuModel();

        public DataTable consultarMenu(string idCuenta)
        {
            return useres.consultarMenu(idCuenta);
        }

        public string GetNombresUsuario(int idusuario)
        {
            UsuarioModel p = new UsuarioModel();
            return p.ConsultarNombresUsuario(useres.cosultarPKPersona(idusuario));
        }
    }
}
