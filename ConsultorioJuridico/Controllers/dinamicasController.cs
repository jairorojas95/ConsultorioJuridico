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
    public class dinamicasController : ApiController
    {

        dinamicasModel pru = new dinamicasModel();

        public bool registro_proceso(dinamicasModel mod)
        {

            pru.registrartipo_proceso(mod);
            return true;

        }

        public DataTable consultarproces()

        {
            return pru.tipo_procesos();

        }


        public bool registro_docum(dinamicasModel mod)
        {

            pru.registrartipo_docuemnto(mod);
            return true;

        }

        public DataTable consultardocm()

        {
            return pru.documento_tipo();

        }
    }
}
