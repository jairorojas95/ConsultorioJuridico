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
    public class ProcesoController : ApiController
    {
        pruebaModel pru = new pruebaModel();
        ProcesoModel proce = new ProcesoModel();


        public bool registro_perosna(pruebaModel mod)
        {

            pru.registraPersona(mod);
            return true;
            
        }

        public bool registropersona(ProcesoModel mod)
        {

            proce.registrarperonsanatural(mod);
            return true;

        }

        public bool registropersonajuridica(ProcesoModel mod)
        {

            proce.registrarperonsajuridica(mod);
            return true;

        }
        public DataTable traerhoja()

        {
            return pru.hoja_ruta();

        }

        public DataTable consultarproces()

        {
            return proce.consulartipo_proceso();

        }

        public DataTable traerdocentes()

        {
            return proce.traerasesor();

        }

        public DataTable traeraimplicados()

        {
            return proce.traeraccionante();

        }

        public DataTable consultarproce()

        {
            return proce.consultarproceso();

        }

        public DataTable consultarestudiante()

        {
            return proce.consultarestudiante();

        }



        public DataTable consultardocumento()

        {
            return proce.consulartipo_documento();

        }

        public bool Registraproceso(ProcesoModel mod)
        {

            proce.registrarproceso(mod);
            return true;
        }

        public bool registrarpersonatest()
        {
            return true;
        }
       
      
    


    }
}