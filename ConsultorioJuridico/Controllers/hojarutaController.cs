using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using juefi2.Models;
using System.Net.Http;
using System.Web.Http;
using System.Data;

namespace juefi2.Controllers
{
    public class hojarutaController : ApiController
    {
        hojarutaModel hoja = new hojarutaModel();

        public DataTable llenarproceso(string idusuario)
        {

            return hoja.consultaprocesodelestudinate(idusuario);

        }
        public bool registro_hojaruta(hojarutaModel mod)
        {

            hoja.registrarhojaruta(mod);
            return true;

        }

        public DataTable consultarproce(string id)

        {
            return hoja.consultarproceso(id);

        }

        public DataTable ctraerestudiante( string id)

        {
            return hoja.traerestudiante(id);

        }
        public bool actualizarhoja(hojarutaModel mod)
        {

            hoja.actualizarhojaruta(mod);

            return true;
        }
    }
}
