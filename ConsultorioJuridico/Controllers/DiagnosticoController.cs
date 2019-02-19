using System;
using System.Collections.Generic;
using juefi2.Models;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace juefi2.Controllers
{
    public class DiagnosticoController : ApiController
    {
        DiagnosticoModel diag = new DiagnosticoModel();


        public bool registro_dignostico(DiagnosticoModel mod)
        {

            diag.registrarDiagnostico(mod);
            return true;

        }

        public DataTable llenardiagnostico( string idusuario) {

            return diag.consultaRD( idusuario );

        }
    }
}
