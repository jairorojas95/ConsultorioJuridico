using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using juefi2.Models;
using System.Web.Http;
using System.Data;

namespace juefi2.Controllers
{
    public class HojaCierreController : ApiController
    {
        HojaCierreModal hojcie = new HojaCierreModal();

        public DataTable llenarproceso(string idusuario)
        {

            return hojcie.consultaprocesodelestudinate(idusuario);

        }

        public bool registrohojacierre(HojaCierreModal mod)
        {

            hojcie.registrarhojacierre(mod);
            return true;

        }

        public DataTable consultarhoja(string idusuario)
        {

            return hojcie.consultarhojacierre(idusuario);

        }

        public DataTable ctraerestudiante()

        {
            return hojcie.traerestudiante();

        }

        public bool actualizarhojacierre(HojaCierreModal mod)
        {

            hojcie.actualizarhojacierre(mod);

            return true;
        }

        public bool actualizaproceso(HojaCierreModal mod)
        {

            hojcie.actualizarproceso(mod);

            return true;
        }
    }
}
