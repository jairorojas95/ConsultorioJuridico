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
    }
}
