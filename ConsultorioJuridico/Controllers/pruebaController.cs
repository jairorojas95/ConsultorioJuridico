using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using juefi2.Controllers;
using juefi2.Models;
using System.Data;

namespace juefi2.Controllers
{
    public class pruebaController : ApiController
    {
        pruebaModel pru = new pruebaModel();


        public bool registro_perosna(pruebaModel mod)
        {

            pru.registraPersona(mod);
            return true;
            
        }
        public DataTable traerhoja()

        {
            return pru.hoja_ruta();

        }

    }
}