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
    public class AsignarProcesoController : ApiController
    {
        AsignarProcesoModal asig = new AsignarProcesoModal();

        public DataTable consultarusuario()

        {
            return asig.consultarusuario();

        }

        public DataTable traerproceso()

        {
            return asig.traerproceso();

        }
    }
}
